using System;
using System.Collections.Generic;
using System.Linq;

using DrumsAcademy.Common.Enums;
using DrumsAcademy.Models;

using NUnit.Framework;

namespace DrumsAcademy.Mvp.Tests.Resource.ResourcePresenter
{
    [TestFixture]
    public class OnResourceChangeShould
    {
        /*[Test]
        public void ChangeResourceIn_When_OnResourceChangeIsRaised()
        {
            // Arrange
            var viewMock = new Mock<IResourcesView>();
            viewMock.Setup(v => v.Model).Returns(new ResourceViewModel());

            var resources = GetCategoriesWithBookResources();
            var resourceServiceMock = new Mock<IResourceService>();
            resourceServiceMock.Setup(c => c.GetAllResources())
                .Returns(resources);

            var booksPresenter = new Mvp.Resource.ResourcePresenter(viewMock.Object, resourceServiceMock.Object);

            // Act
            viewMock.Raise(v => v.OnResourcesGetData += null, EventArgs.Empty);

            // Assert
            CollectionAssert.AreEquivalent(resources, viewMock.Object.Model.Resources);
        }*/
        private IQueryable<Models.Resource> GetCategoriesWithResources()
        {
            return
                new List<Models.Resource>()
                    {
                        new Models.Resource()
                            {
                                Id = Guid.NewGuid(),
                                Type = ResourceType.Video,
                                Title = "First drum lesson expectations",
                                Description =
                                    "What you should expect from your first lesson.",
                                Level = LevelType.Basic,
                                Category =
                                    new Category
                                        {
                                            Id = Guid.NewGuid(),
                                            Type = CategoryType.QnA
                                        },
                                Url =
                                    "https://www.youtube.com/watch?v=B8sBX5xvSz8"
                            },
                        new Models.Resource()
                            {
                                Id = Guid.NewGuid(),
                                Type = ResourceType.Video,
                                Title =
                                    "How to play 7/8 on drums and be musical",
                                Description =
                                    "Easing into odd time signature. In this case 7/8. It\'s important to make your odd time drumming pattern sound musical with a strong pulse.",
                                Level = LevelType.Intermediate,
                                Category =
                                    new Category
                                        {
                                            Id = Guid.NewGuid(),
                                            Type = CategoryType.QnA
                                        },
                                Url =
                                    "https://www.youtube.com/watch?v=k_ip7fiRGeU"
                            },
                    }.AsQueryable();
        }
    }
}