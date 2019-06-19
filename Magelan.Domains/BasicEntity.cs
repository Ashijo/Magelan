using System;

namespace Magelan.Domains {
    public class BasicEntity {
        public Guid Id { get; set; }

        public DateTime Creation { get; set; }
        public bool Deleted { get; set; }
        public bool Archive { get; set; }

    }
}