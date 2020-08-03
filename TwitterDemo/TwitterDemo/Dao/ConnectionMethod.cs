using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TwitterDemo.Models;
using System.Configuration;
using System.Dynamic;
using System.Threading;
using System.Linq.Expressions;
using System.Diagnostics;

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

        /// <summary>
        /// ユーザー取得
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User GetUser(User user)
        {
            var rtnUser = _ctx.Users.Where(u => u.UserId == user.UserId && u.Password == user.Password).ToList().FirstOrDefault();

            return rtnUser;
        }

        /// <summary>
        /// 投稿文取得
        /// </summary>
        /// <returns></returns>
        public List<Article> GetArticles()
        {
            List<Article> articleList = new List<Article>();
            Article article = new Article();

            var query =
                        from u in _ctx.Users
                        join t in _ctx.Thread
                        on u.UserId equals t.UserId
                        select new Article
                        {
                            ThreadId = t.ThreadId,
                            UserId = u.UserId,
                            Contents = t.Contents,
                            AccountName = u.AccountName,
                            AccountType = u.AccountType,
                            UpdateDateTime = t.UpdateDateTime
                        };

            foreach (var a in query)
            {
                article.ThreadId = a.ThreadId;
                article.UserId = a.UserId;
                article.Contents = a.Contents;
                article.AccountName = a.AccountName;
                article.AccountType = a.AccountType;
                article.UpdateDateTime = a.UpdateDateTime;

                articleList.Add(article);
            }


            return articleList;
        }

        public void AddThread()
        {

        }
    }
}