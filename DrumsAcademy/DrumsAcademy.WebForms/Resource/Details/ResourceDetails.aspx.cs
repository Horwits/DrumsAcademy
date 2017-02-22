using System;
using System.Web.ModelBinding;

using DrumsAcademy.Mvp.Resource.Details;

using WebFormsMvp;
using WebFormsMvp.Web;

namespace DrumsAcademy.WebForms.Resource.Details
{
    [PresenterBinding(typeof(ResourceDetailsPresenter))]
    public partial class ResourceDetails : MvpPage<ResourceDetailsViewModel>, IResourceDetailsView
    {
        public event EventHandler<IdEventArgs> OnGetResource;

        public Models.Resource On_GetResource([QueryString] Guid? id)
        {
            this.OnGetResource?.Invoke(this, new IdEventArgs(id));

            return this.Model.Resource;
        }
    }
}