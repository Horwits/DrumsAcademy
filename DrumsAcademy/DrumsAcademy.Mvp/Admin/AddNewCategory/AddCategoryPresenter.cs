using DrumsAcademy.Services.Data.Contracts;

using WebFormsMvp;

namespace DrumsAcademy.Mvp.Admin.AddNewCategory
{
    public class AddCategoryPresenter : Presenter<ICategoryControlView>
    {
        private readonly ICategoryService service;

        public AddCategoryPresenter(ICategoryControlView view, ICategoryService service)
            : base(view)
        {
            this.service = service;

            this.View.OnAddNewCategory += this.View_OnAddNewCategory;
        }

        private void View_OnAddNewCategory(object sender, CategoryEventArgs e)
        {
            this.service.AddCategory(e.Category);
        }
    }
}