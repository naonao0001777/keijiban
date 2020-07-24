using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TwitterDemo.Models;
using System.Configuration;

namespace TwitterDemo.Dao
{
    public class ConnectionMethod
    {
        public User GetUser(User user)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwitterDemo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            var ctx = new UserDbContext(connectionString);

            var rtnUser = ctx.Users.Where(u => u.UserId == user.UserId && u.Password == user.Password).ToList().FirstOrDefault();

            return rtnUser;
        }
    }
}