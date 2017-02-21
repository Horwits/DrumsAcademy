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
        private readonly IDrumsAcademyContext context;

        public CategoryService(IDrumsAcademyContext context)
        {
            this.context = context;
        }

        public int AddCategory(Category category)
        {
            this.context.Categories.Add(category);

            return this.context.SaveChanges();
        }

        public int DeleteCategory(Guid categoryId)
        {
            var category = this.context.Categories.Find(categoryId);
            this.context.Categories.Remove(category);

            return this.context.SaveChanges();
        }

        public IQueryable<Category> GetAllCategoriesSortedById()
        {
            return this.context.Categories.OrderBy(c => c.Id);
        }

        public IQueryable<Category> GetAllCategoriesSortedByType()
        {
            return this.context.Categories.OrderBy(c => c.Type);
        }

        public IQueryable<Category> GetAllCategoriesWithResourcesIncluded()
        {
            return this.context.Categories.Include(r => r.Resources);
        }

        public Category GetById(Guid id)
        {
            return this.context.Categories.SingleOrDefault(c => c.Id == id);
        }

        public int UpdateCategory(Category category)
        {
            var entry = this.context.Entry(category);
            entry.State = EntityState.Modified;

            return this.context.SaveChanges();
        }
    }
}