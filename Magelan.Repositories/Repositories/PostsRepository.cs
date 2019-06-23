using Magelan.Domains;
using Magelan.Repositories.Base;
using Magelan.Repositories.DbContexts;
using Magelan.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Magelan.Repositories.Repositories {
    public class PostsRepository : CrudableRepository<Posts>, IPostRepository {
        public PostsRepository(MagelanDbContext context) : base(context) { }
    }
}