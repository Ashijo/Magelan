using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Magelan.Domains;
using Magelan.Repositories.Base;
using Magelan.Repositories.DbContexts;
using Magelan.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Magelan.Repositories.Repositories {
    public class UserRepository : CrudableRepository<MagelanUser>, IUserRepository{
        public UserRepository(MagelanDbContext context) : base(context) { }

     
        
    }
}