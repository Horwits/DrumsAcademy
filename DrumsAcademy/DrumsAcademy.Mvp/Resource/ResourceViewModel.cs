using System.Linq;

namespace DrumsAcademy.Mvp.Resource
{
    public class ResourceViewModel
    {
        public IQueryable<Models.Resource> LastTenResources { get; set; }

        public IQueryable<Models.Resource> Resources { get; set; }
    }
}