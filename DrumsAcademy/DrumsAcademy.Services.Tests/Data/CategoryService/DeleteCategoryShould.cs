using System;
using System.Collections.Generic;
using System.Data.Entity;

using DrumsAcademy.Common.Enums;
using DrumsAcademy.Data.Contracts.DbContext;
using DrumsAcademy.Models;

using Moq;

using NUnit.Framework;

namespace DrumsAcademy.Services.Tests.Data.CategoryService
{
    [TestFixture]
    public class DeleteCategoryShould
    {
        [Test]
        public void Delete_CategoryFromDbSetCategories_When_ValidIdIsPassed()
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
            var numberOfRowsAffected = categoryService.DeleteCategory(categoryId);

            // Assert
            /*CollectionAssert.DoesNotContain(categoryResult, category);*/
            Assert.AreEqual(numberOfRowsAffected, 1);
        }

        private IList<Category> GetCategories()
        {
            var categories = new List<Category>
                                 {
                                     new Category() { Id = Guid.NewGuid(), Type = CategoryType.Hand },
                                     new Category() { Id = Guid.NewGuid(), Type = CategoryType.Feet }
                                 };
            return categories;
        }
    }
}