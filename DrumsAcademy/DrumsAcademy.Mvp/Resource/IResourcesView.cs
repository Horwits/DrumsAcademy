using System;

using WebFormsMvp;

namespace DrumsAcademy.Mvp.Resource
{
    public interface IResourcesView : IView<ResourceViewModel>
    {
        event EventHandler OnResourcesGetData;
    }
}