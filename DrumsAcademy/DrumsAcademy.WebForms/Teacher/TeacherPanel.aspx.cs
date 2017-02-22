using System;
using System.Linq;

using DrumsAcademy.Mvp.Resource;
using DrumsAcademy.Mvp.Resource.Details;

using WebFormsMvp;
using WebFormsMvp.Web;

namespace DrumsAcademy.WebForms.Teacher
{
    [PresenterBinding(typeof(ResourcePresenter))]
    public partial class TeacherPanel : MvpPage<ResourceViewModel>, IResourcesView
    {
        public event EventHandler<IdEventArgs> OnResourceChange;

        public event EventHandler<ResourceEventArgs> OnResourceCreate;

        public event EventHandler<IdEventArgs> OnResourceDelete;

        public event EventHandler OnResourcesGetData;

        public void ListView1_DeleteItem(Guid? id)
        {
            this.OnResourceDelete?.Invoke(this, new IdEventArgs(id));
        }

        public IQueryable<Models.Resource> ListView1_GetData()
        {
            this.OnResourcesGetData?.Invoke(this, null);

            return this.Model.Resources;
        }

        public void ListView1_UpdateItem(Guid? id)
        {
            this.OnResourceChange?.Invoke(this, new IdEventArgs(id));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}