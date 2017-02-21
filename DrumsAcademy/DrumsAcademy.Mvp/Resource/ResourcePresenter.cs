using System;

using DrumsAcademy.Services.Data.Contracts;

using WebFormsMvp;

namespace DrumsAcademy.Mvp.Resource
{
    public class ResourcePresenter : Presenter<IResourcesView>
    {
        private readonly IResourceService service;

        public ResourcePresenter(IResourcesView view, IResourceService service)
            : base(view)
        {
            this.service = service;
            this.View.OnResourcesGetData += this.View_OnResourcesGetData;
        }

        private void View_OnResourcesGetData(object sender, EventArgs e)
        {
            this.View.Model.Resources = this.service.GetAllResources();
        }
    }
}