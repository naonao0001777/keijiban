using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterDemo.Models;
using System.Data.SqlClient;
using TwitterDemo.Dao;

namespace TwitterDemo.Controllers
{
    public class LoginController : Controller
    {
        /// <summary>
        /// ログイン画面(初期表示)
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// ログイン画面(再表示)
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (user == null)
            {
                return View();
            }

            ConnectionMethod conMethod = new ConnectionMethod();

            var getUser = conMethod.GetUser(user);

            if (getUser == null)
            {
                return View();
            }
            else
            {
                Session["userInfo"] = user;

                return RedirectToAction("Menu", "Menu",getUser);
            }
        }
    }
}