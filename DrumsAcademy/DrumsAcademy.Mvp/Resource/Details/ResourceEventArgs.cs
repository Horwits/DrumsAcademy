using System;

namespace DrumsAcademy.Mvp.Resource.Details
{
    public class ResourceEventArgs : EventArgs
    {
        public ResourceEventArgs(Guid? id)
        {
            this.Id = id;
        }

        public Guid? Id { get; private set; }
    }
}