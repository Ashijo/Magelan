using System;
using Magelan.Domains;
using Magelan.Repositories.DbContexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Magelan.Services.Services {
    public class UserService {
        
        public static void Add(ApplicationUser user, string password, [FromServices] MagelanDbContext dbContext) {
            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();
            
            user.Id = Guid.NewGuid();
            user.NormalizedEmail = user.Email.Normalize();
            user.NormalizedUserName = user.UserName.Normalize();
            user.PasswordHash = hasher.HashPassword(user, password);

            dbContext.ApplicationUsers.Add(user);
            dbContext.SaveChanges();
        }
        
    }
}