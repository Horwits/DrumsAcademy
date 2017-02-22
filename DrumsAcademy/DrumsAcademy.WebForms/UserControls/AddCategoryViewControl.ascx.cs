using System;

using DrumsAcademy.Common.Enums;
using DrumsAcademy.Models;
using DrumsAcademy.Mvp.Admin.AddNewCategory;

using WebFormsMvp.Web;

namespace DrumsAcademy.WebForms.UserControls
{
    public partial class AddCategoryViewControl : MvpUserControl<CategoryControlViewModel>, ICategoryControlView
    {
        public event EventHandler<CategoryEventArgs> OnAddNewCategory;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void RoleSenderID_OnClick(object sender, EventArgs e)
        {
            var role = this.RoleLiteral.Text;
            CategoryType categoryType;
            var isParsed = Enum.TryParse(role, out categoryType);

            var category = new Category();
            category.Type = categoryType;

            this.OnAddNewCategory?.Invoke(sender, new CategoryEventArgs(category));
        }
    }
}