namespace CustomerManagmentBusinessLayer
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {
        public EntityStateOption Entity { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid
        {
            get { return true;  }
        }
    }
}
