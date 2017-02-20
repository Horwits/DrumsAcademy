using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using DrumsAcademy.Models;

namespace DrumsAcademy.Data.Contracts.DbContext
{
    public interface IDrumsAcademyContext : IDrumsAcademyBaseContext
    {
        IDbSet<Category> Categories { get; set; }

        IDbSet<Resource> Resources { get; set; }

        DbEntityEntry Entry(object entity);
    }
}