using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Magelan.Repositories.DbContexts {
    public class MagelanDbContextFactory : IDesignTimeDbContextFactory<MagelanDbContext>
    {
        public MagelanDbContext CreateDbContext(string[] args) {
            var optionsBuilder = new DbContextOptionsBuilder<MagelanDbContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=Magelan;User=username;Password=password;",
                mySqlOptions => { mySqlOptions.ServerVersion(new Version(10, 3, 15), ServerType.MariaDb); }
            );

            return new MagelanDbContext(optionsBuilder.Options);
            
        }
    }
}