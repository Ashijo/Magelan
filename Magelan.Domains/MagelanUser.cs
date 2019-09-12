using System;

namespace Magelan.Domains
{
    public class MagelanUser : ICrudableEntity, IGuidKey
    {
        public DateTime Creation { get; set; }
        public bool Deleted { get; set; }
        public DateTime DeletedDateTime { get; set; }
        public bool Archive { get; set; }
        public DateTime ArchiveDateTime { get; set; }
        public Guid Id { get; set; }
    }
}