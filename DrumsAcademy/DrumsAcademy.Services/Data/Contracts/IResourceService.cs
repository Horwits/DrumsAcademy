using System;
using System.Linq;

using DrumsAcademy.Common.Enums;
using DrumsAcademy.Models;

namespace DrumsAcademy.Services.Data.Contracts
{
    public interface IResourceService
    {
        int DeleteResource(Guid? resourceId);

        IQueryable<Resource> GetAllResources();

        Resource GetResourceById(Guid? id);

        Resource GetResourceByTitle(string title);

        IQueryable<Resource> GetResourcesByType(ResourceType type);

        IQueryable<Resource> GetTenLatestResources();

        int InsertResource(Resource resource);

        int UpdateResource(Resource resource);
    }
}