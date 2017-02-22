using System;

using DrumsAcademy.Mvp.Resource.Details;

using WebFormsMvp;

namespace DrumsAcademy.Mvp.Resource
{
    public interface IResourcesView : IView<ResourceViewModel>
    {
        event EventHandler<IdEventArgs> OnResourceChange;

        event EventHandler<ResourceEventArgs> OnResourceCreate;

        event EventHandler<IdEventArgs> OnResourceDelete;

        event EventHandler OnResourcesGetData;
    }
}