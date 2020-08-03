using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterDemo.Dao;
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
        [ValidateAntiForgeryToken]
        public ActionResult Menu(string accountbtn, string logoutbtn, string article)
        {
            if (accountbtn != null)
            {
                return RedirectToAction("Account", "Account");
            }
            else if (logoutbtn != null)
            {
                return RedirectToAction("Login", "Login");
            }
            else if (article != null)
            {
                return RedirectToAction("Thread","Thread");
            }
            return View();
        }
    }
}