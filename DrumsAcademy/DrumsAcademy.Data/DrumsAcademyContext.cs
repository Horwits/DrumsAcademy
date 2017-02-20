using System.Data.Entity;

using DrumsAcademy.Data.Contracts.DbContext;
using DrumsAcademy.Models;

namespace DrumsAcademy.Data
{
    public class DrumsAcademyContext : DbContext, IDrumsAcademyContext
    {
        public DrumsAcademyContext()
            : base("DrumsAcademyDB")
        {
        }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Resource> Resources { get; set; }
    }
}