using System;
using System.Linq;

using DrumsAcademy.Models;

namespace DrumsAcademy.Services.Data.Contracts
{
    public interface ICategoryService
    {
        int AddCategory(Category category);

        int DeleteCategory(Guid categoryId);

        IQueryable<Category> GetAllCategoriesSortedById();

        IQueryable<Category> GetAllCategoriesSortedByType();

        IQueryable<Category> GetAllCategoriesWithResourcesIncluded();

        Category GetById(Guid id);

        int UpdateCategory(Category category);
    }
}