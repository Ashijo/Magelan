using System;

namespace Magelan.Domains
{
    public interface ICrudableEntity : IBasicEntity
    {
        bool Deleted { get; set; }
        DateTime DeletedDateTime { get; set; }
        bool Archive { get; set; }
        DateTime ArchiveDateTime { get; set; }
    }
}