using System;
using System.Data.Entity;
using System.Linq;

using Bytes2you.Validation;

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
            Guard.WhenArgument(category, "category").IsNull().Throw();
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

        public Category GetById(Guid id)
        {
            return this.context.Categories.Find(id);
        }

        public int UpdateCategory(Category category)
        {
            var entry = this.context.Entry(category);
            entry.State = EntityState.Modified;

            return this.context.SaveChanges();
        }
    }
}