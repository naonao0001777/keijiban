using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterDemo.Models;

namespace TwitterDemo.Controllers
{
    public class MenuController : Controller
    {
        /// <summary>
        /// メニュー画面リダイレクト用
        /// </summary>
        /// <returns></returns>
        public ActionResult Menu(User user)
        {
            return View(user);
        }

        /// <summary>
        /// メニュー画面
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Menu(string param)
        {
            if (param == "accountbtn")
            {
                RedirectToAction("Account","Account");
            }
            else if (param == "logoutbtn")
            {
                RedirectToAction("Login","Login");
            }

            return View();
        }
    }
}