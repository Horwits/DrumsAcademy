using System;
using System.Linq;

using DrumsAcademy.Mvp.Resource;
using DrumsAcademy.Mvp.Resource.Details;

using WebFormsMvp;
using WebFormsMvp.Web;

namespace DrumsAcademy.WebForms.Resource
{
    [PresenterBinding(typeof(ResourcePresenter))]
    public partial class Resources : MvpPage<ResourceViewModel>, IResourcesView
    {
        public event EventHandler<IdEventArgs> OnResourceChange;

        public event EventHandler<ResourceEventArgs> OnResourceCreate;

        public event EventHandler<IdEventArgs> OnResourceDelete;

        public event EventHandler OnResourcesGetData;

        public IQueryable<Models.Resource> ListViewResources_GetData()
        {
            this.OnResourcesGetData?.Invoke(this, null);
            return this.Model.Resources;
        }
    }
}