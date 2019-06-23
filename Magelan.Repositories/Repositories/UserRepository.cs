using Magelan.Repositories.Base;
using Magelan.Repositories.DbContexts;
using Magelan.Repositories.Interfaces;

namespace Magelan.Repositories.Repositories {
    public class UserRepository : CrudableRepository<AspNetUsers>, IUserRepository{
        public UserRepository(MagelanDbContext context) : base(context) { }
        
    }
}