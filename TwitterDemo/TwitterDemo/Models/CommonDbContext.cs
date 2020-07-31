using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading;

namespace TwitterDemo.Models
{
    public class CommonDbContext : DbContext
    {
        public CommonDbContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<CommonDbContext>(null);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Threads> Thread { get; set; }
    }
}