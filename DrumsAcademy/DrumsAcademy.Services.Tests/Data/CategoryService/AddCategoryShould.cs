using System;
using System.Collections.Generic;
using System.Linq;

using DrumsAcademy.Common.Enums;
using DrumsAcademy.Data.Contracts.DbContext;
using DrumsAcademy.Models;
using DrumsAcademy.Services.Tests.Mocks;

using Moq;

using NUnit.Framework;

namespace DrumsAcademy.Services.Tests.Data.CategoryService
{
    [TestFixture]
    public class AddCategoryShould
    {
        [Test]
        public void Throw_ArgumentNullException_When_NullIsPassed()
        {
            // Arrange
            var fakeDrumsAcademyContext = new Mock<IDrumsAcademyContext>();
            var sut = new Services.Data.CategoryService(fakeDrumsAcademyContext.Object);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.AddCategory(null));
        }

        [Test]
        public void Add_CategoryToDbSetCategories_When_Valid()
        {
            // Arrange
            var fakeDrumsAcademyContext = new Mock<IDrumsAcademyContext>();

            var fakeCategoriesDbSet = QueryableDbSetMock.GetQueryableMockDbSetFromList(this.GetCategories());

            fakeDrumsAcademyContext.Setup(f => f.Categories).Returns(fakeCategoriesDbSet);

            var sut = new Services.Data.CategoryService(fakeDrumsAcademyContext.Object);

            var category = new Category() { Id = Guid.NewGuid(), Type = CategoryType.Theory };

            var categoriesCount = fakeCategoriesDbSet.Count();

            // Act
            sut.AddCategory(category);
            categoriesCount += 1;

            // Assert
            Assert.AreEqual(categoriesCount, fakeCategoriesDbSet.Count());
        }

        private IList<Category> GetCategories()
        {
            var categories = new List<Category> {
                                     new Category() { Id = Guid.NewGuid(), Type = CategoryType.Hand },
                                     new Category() { Id = Guid.NewGuid(), Type = CategoryType.Feet }
                                 };

            return categories;
        }
    }
}
