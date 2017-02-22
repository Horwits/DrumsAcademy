using System;

using WebFormsMvp;

namespace DrumsAcademy.Mvp.Admin.AddNewCategory
{
    public interface ICategoryControlView : IView<CategoryControlViewModel>
    {
        event EventHandler<CategoryEventArgs> OnAddNewCategory;
    }
}