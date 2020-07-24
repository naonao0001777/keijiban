using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TwitterDemo.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<UserDbContext>(null);
        }

        public DbSet<User> Users { get; set; }
    }
}