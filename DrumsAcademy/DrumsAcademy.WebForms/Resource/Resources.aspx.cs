using System;
using System.Linq;

using DrumsAcademy.Mvp.Resource;

using WebFormsMvp;
using WebFormsMvp.Web;

namespace DrumsAcademy.WebForms.Resource
{
    [PresenterBinding(typeof(ResourcePresenter))]
    public partial class Resources : MvpPage<ResourceViewModel>, IResourcesView
    {
        public event EventHandler OnResourcesGetData;

        public IQueryable<Models.Resource> ListViewResources_GetData()
        {
            this.OnResourcesGetData?.Invoke(this, null);
            return this.Model.Resources;
        }
    }
}