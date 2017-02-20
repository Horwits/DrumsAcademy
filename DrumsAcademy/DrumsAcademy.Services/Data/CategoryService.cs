using System;
using System.Data.Entity;
using System.Linq;

using DrumsAcademy.Data.Contracts.DbContext;
using DrumsAcademy.Models;
using DrumsAcademy.Services.Data.Contracts;

namespace DrumsAcademy.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly IDrumsAcademyContext drumsAcademyContext;

        public CategoryService(IDrumsAcademyContext drumsAcademyContext)
        {
            this.drumsAcademyContext = drumsAcademyContext;
        }

        public IQueryable<Category> GetAllCategoriesWithResourcesIncluded()
        {
            return this.drumsAcademyContext.Categories.Include(r => r.Resources);
        }

        public IQueryable<Category> GetAllCategoriesSortedByType()
        {
            return this.drumsAcademyContext.Categories.OrderBy(c => c.Type);
        }

        public IQueryable<Category> GetAllCategoriesSortedById()
        {
            return this.drumsAcademyContext.Categories.OrderBy(c => c.Id);

        }

        public Category GetById(Guid id)
        {
            return this.drumsAcademyContext.Categories.SingleOrDefault(c => c.Id == id);
        }

        public int AddCategory(Category category)
        {
            this.drumsAcademyContext.Categories.Add(category);

            return this.drumsAcademyContext.SaveChanges();
        }

        public int DeleteCategory(Guid categoryId)
        {

            var category = this.drumsAcademyContext.Categories.Find(categoryId);
            this.drumsAcademyContext.Categories.Remove(category);

            return this.drumsAcademyContext.SaveChanges();
        }

        public int UpdateCategory(Category category)
        {
            var entry = this.drumsAcademyContext.Entry(category);
            entry.State = EntityState.Modified;

            return this.drumsAcademyContext.SaveChanges();
        }
    }
}
