using Magelan.Domains;
using Microsoft.EntityFrameworkCore;

namespace Magelan.Repositories.DbContexts {
    public class MagelanDbContext : DbContext {
        public MagelanDbContext(DbContextOptions<MagelanDbContext> options) : base(options) {
        }

        
        
        public DbSet<Post> Posts { get; set; }

    }
}