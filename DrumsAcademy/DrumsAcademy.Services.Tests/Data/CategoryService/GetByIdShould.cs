using System;
using System.Data.Entity;

using DrumsAcademy.Data.Contracts.DbContext;
using DrumsAcademy.Models;

using Moq;

using NUnit.Framework;

namespace DrumsAcademy.Services.Tests.Data.CategoryService
{
    [TestFixture]
    public class GetByIdShould
    {
        [Test]
        public void ReturnNull_When_NotFound()
        {
            // Arrange
            var contextMock = new Mock<IDrumsAcademyContext>();
            var categoryService = new Services.Data.CategoryService(contextMock.Object);

            var categorySetMock = new Mock<IDbSet<Category>>();
            contextMock.Setup(x => x.Categories).Returns(categorySetMock.Object);

            // Act
            var bookResult = categoryService.GetById(Guid.NewGuid());

            // Assert
            Assert.IsNull(bookResult);
        }

        [Test]
        public void ReturnsCategory_When_Found()
        {
            // Arrange
            var contextMock = new Mock<IDrumsAcademyContext>();

            var categorySetMock = new Mock<IDbSet<Category>>();
            contextMock.Setup(x => x.Categories).Returns(categorySetMock.Object);

            var categoryId = Guid.NewGuid();
            var category = new Category { Id = categoryId };

            categorySetMock.Setup(b => b.Find(categoryId)).Returns(category);

            var categoryService = new Services.Data.CategoryService(contextMock.Object);

            // Act
            var categoryResult = categoryService.GetById(categoryId);

            // Assert
            Assert.AreSame(categoryResult, category);
        }
    }
}