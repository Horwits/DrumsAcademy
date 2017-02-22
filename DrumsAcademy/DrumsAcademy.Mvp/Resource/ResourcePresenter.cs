using System;

using DrumsAcademy.Mvp.Resource.Details;
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
            this.View.OnResourceChange += this.View_OnResourceChange;
            this.View.OnResourceDelete += this.View_OnResourceDelete;
            this.View.OnResourceCreate += this.View_OnResourceCreate;
        }

        private void View_OnResourceChange(object sender, IdEventArgs e)
        {
            Models.Resource resource = this.service.GetResourceById(e.Id);
            this.service.UpdateResource(resource);
        }

        private void View_OnResourceCreate(object sender, ResourceEventArgs e)
        {
            this.service.InsertResource(e.Resource);
        }

        private void View_OnResourceDelete(object sender, IdEventArgs e)
        {
            this.service.DeleteResource(e.Id);
        }

        private void View_OnResourcesGetData(object sender, EventArgs e)
        {
            this.View.Model.Resources = this.service.GetAllResources();
        }
    }
}