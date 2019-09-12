using System;
using System.Collections.Generic;
using Magelan.Domains;

namespace Magelan.Repositories
{
    public class Posts : ICrudableEntity, IIntKey
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Creation { get; set; }
        public bool Deleted { get; set; }
        public DateTime DeletedDateTime { get; set; }
        public bool Archive { get; set; }
        public DateTime ArchiveDateTime { get; set; }
        public int Id { get; set; }
    }
}
