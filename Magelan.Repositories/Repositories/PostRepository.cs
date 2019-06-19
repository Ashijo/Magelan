using Magelan.Domains;
using Magelan.Repositories.Base;
using Magelan.Repositories.DbContexts;
using Magelan.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Magelan.Repositories.Repositories {
    public class PostRepository : Repository<Post>, IPostRepository {
        public PostRepository(MagelanDbContext context) : base(context) { }
    }
}