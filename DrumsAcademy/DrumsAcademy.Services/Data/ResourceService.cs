using System;
using System.Data.Entity;
using System.Linq;

using Bytes2you.Validation;

using DrumsAcademy.Common.Enums;
using DrumsAcademy.Common.ExtensionMethods;
using DrumsAcademy.Data.Contracts.DbContext;
using DrumsAcademy.Models;
using DrumsAcademy.Services.Data.Contracts;

namespace DrumsAcademy.Services.Data
{
    public class ResourceService : IResourceService
    {
        private readonly IDrumsAcademyContext context;

        public ResourceService(IDrumsAcademyContext context)
        {
            this.context = context;
        }

        public int DeleteResource(Guid resourceId)
        {
            var resourceToDelete = this.context.Resources.Find(resourceId);
            this.context.Resources.Remove(resourceToDelete);

            return this.context.SaveChanges();
        }

        public IQueryable<Resource> GetAllResources()
        {
            return this.context.Resources;
        }

        public Resource GetResourceById(Guid? id)
        {
            return this.context.Resources.Find(id);
        }

        public Resource GetResourceByTitle(string title)
        {
            Guard.WhenArgument(title, "title").IsNullOrEmpty().Throw();
            return this.context.Resources.SingleOrDefault(r => r.Title.Contains(title));
        }

        public IQueryable<Resource> GetResourcesByType(ResourceType type)
        {
            return this.context.Resources.Where(x => x.Type == type);
        }

        public IQueryable<Resource> GetTenLatestResources()
        {
            const int Ten = 10;
            return this.context.Resources.TakeLast(Ten).AsQueryable();
        }

        public int InsertResource(Resource resource)
        {
            this.context.Resources.Add(resource);

            return this.context.SaveChanges();
        }

        public int UpdateResource(Resource resource)
        {
            var entry = this.context.Entry(resource);
            entry.State = EntityState.Modified;

            return this.context.SaveChanges();
        }
    }
}