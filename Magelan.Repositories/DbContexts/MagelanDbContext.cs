using Magelan.Domains;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Magelan.Repositories.DbContexts {
    public class MagelanDbContext : IdentityDbContext {
        public MagelanDbContext(DbContextOptions<MagelanDbContext> options) : base(options) {
        }

        public DbSet<Post> Posts { get; set; }

    }
}