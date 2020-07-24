using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            return View();
        }

        /// <summary>
        /// 掲示板画面
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Thread(User user)
        {
            return View();
        }
    }
}