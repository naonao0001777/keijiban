using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TwitterDemo.Models;
using System.Configuration;
using System.Dynamic;
using System.Threading;
using System.Linq.Expressions;

namespace TwitterDemo.Dao
{
    public class ConnectionMethod
    {
        public CommonDbContext _ctx; 

        public ConnectionMethod()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BulltinBordProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            _ctx = new CommonDbContext(connectionString);
        }

        public User GetUser(User user)
        {
            var rtnUser = _ctx.Users.Where(u => u.UserId == user.UserId && u.Password == user.Password).ToList().FirstOrDefault();

            return rtnUser;
        }

        public IQueryable GetThread()
        {
            var query =
                        from u in _ctx.Users
                        join t in _ctx.Thread
                        on u.UserId equals t.UserId
                        select new
                        {
                            AccountName = u.AccountName,
                            AccountType = u.AccountType,
                            Contents = t.Contents
                        };

            return query;
        }
    }
}