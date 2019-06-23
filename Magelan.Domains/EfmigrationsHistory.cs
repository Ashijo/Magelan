using System;
using System.Collections.Generic;

namespace Magelan.Repositories
{
    public partial class EfmigrationsHistory
    {
        public string MigrationId { get; set; }
        public string ProductVersion { get; set; }
    }
}
