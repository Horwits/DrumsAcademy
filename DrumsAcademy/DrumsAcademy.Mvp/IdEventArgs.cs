using System;

namespace DrumsAcademy.Mvp.Resource.Details
{
    public class IdEventArgs : EventArgs
    {
        public IdEventArgs(Guid? id)
        {
            this.Id = id;
        }

        public Guid? Id { get; private set; }
    }
}