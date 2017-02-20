using System;
using System.Linq;

using DrumsAcademy.Models;

namespace DrumsAcademy.Services.Data.Contracts
{
    public interface ICategoryService
    {
        IQueryable<Category> GetAllCategoriesWithResourcesIncluded();

        IQueryable<Category> GetAllCategoriesSortedByType();

        IQueryable<Category> GetAllCategoriesSortedById();

        Category GetById(Guid id);

        int AddCategory(Category category);

        int DeleteCategory(Guid categoryId);

        int UpdateCategory(Category category);
    }
}
