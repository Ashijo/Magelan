using System;
using System.Collections.Generic;
using Magelan.Domains;

namespace Magelan.Repositories
{
    public partial class Posts : BasicEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
