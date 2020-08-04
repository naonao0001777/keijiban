using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterDemo.Dao;
using TwitterDemo.Models;

namespace TwitterDemo.Controllers
{
    public class ThreadController : Controller
    {
        /// <summary>
        /// 掲示板画面（リダイレクト用）
        /// </summary>
        /// <returns></returns>
        public ActionResult Thread()
        {
            ConnectionMethod method = new ConnectionMethod();
            var articles = method.GetArticles();

            return View(articles);
        }

        /// <summary>
        /// 掲示板画面
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Thread(string contents)
        {
            User user = new User();
            user = (User)Session["userInfo"];

            ConnectionMethod method = new ConnectionMethod();
            method.AddThread(user,contents);

            return View();
        }
    }
}