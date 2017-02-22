using System;

namespace DrumsAcademy.Mvp.Resource
{
    public class ResourceEventArgs : EventArgs
    {
        public ResourceEventArgs(Models.Resource resource)
        {
            this.Resource = resource;
        }

        public Models.Resource Resource { get; set; }
    }
}