using DrumsAcademy.Services.Data.Contracts;

using WebFormsMvp;

namespace DrumsAcademy.Mvp.Resource.Details
{
    public class ResourceDetailsPresenter : Presenter<IResourceDetailsView>
    {
        private readonly IResourceService service;

        public ResourceDetailsPresenter(IResourceDetailsView view, IResourceService service)
            : base(view)
        {
            this.service = service;

            this.View.OnGetResource += this.On_GetResource;
        }

        private void On_GetResource(object sender, IdEventArgs e)
        {
            this.View.Model.Resource = this.service.GetResourceById(e.Id);
        }
    }
}