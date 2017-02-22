using System;

using DrumsAcademy.Models;

namespace DrumsAcademy.Mvp.Admin.AddNewCategory
{
    public class CategoryEventArgs : EventArgs
    {
        public CategoryEventArgs(Category category)
        {
            this.Category = category;
        }

        public Category Category { get; set; }
    }
}