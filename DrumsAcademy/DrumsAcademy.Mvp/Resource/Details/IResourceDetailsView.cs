using System;

using WebFormsMvp;

namespace DrumsAcademy.Mvp.Resource.Details
{
    public interface IResourceDetailsView : IView<ResourceDetailsViewModel>
    {
        event EventHandler<IdEventArgs> OnGetResource;
    }
}