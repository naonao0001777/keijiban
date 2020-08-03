using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterDemo.Models;

namespace TwitterDemo.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// アカウント更新画面（リダイレクト用）
        /// </summary>
        /// <returns></returns>
        public ActionResult Account()
        {
            return View();
        }

        /// <summary>
        /// アカウント更新画面
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Account(User user)
        {
            return View(user);
        }
    }
}