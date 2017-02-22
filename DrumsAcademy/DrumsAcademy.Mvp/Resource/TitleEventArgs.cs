using System;

namespace DrumsAcademy.Mvp.Resource
{
    public class TitleEventArgs : EventArgs
    {
        public TitleEventArgs(string title)
        {
            this.Title = title;
        }

        public string Title { get; set; }
    }
}