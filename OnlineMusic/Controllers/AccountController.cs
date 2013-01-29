using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMusic.Models;

namespace OnlineMusic.Controllers
{
    public class AccountController : Controller
    {
        #region LogOn
        OnlineMusicContext db = new OnlineMusicContext();
        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(Admin accout)
        {
            if (ModelState.IsValid)
            {
                var count = (from i in db.Admin
                             where i.UserName == accout.UserName && i.Password == accout.Password
                             select i).Count();
                if (count > 0)
                {
                    ViewBag.UserName= accout.UserName;
                    return RedirectToAction("Index", "Home",ViewBag.UserName);
                }
                else
                {
                    ViewBag.ErrorMessage = "The user name or password is incorrect.";
                }
            }
            return View(accout);
        }
        #endregion
    }
}
