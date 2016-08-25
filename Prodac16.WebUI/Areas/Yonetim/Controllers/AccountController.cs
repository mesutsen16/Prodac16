using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Prodac16.WebUI.Areas.Yonetim.Models.Dto;
using Prodac16.WebUI.Models.Orm.Context;


namespace Prodac16.WebUI.Areas.Yonetim.Controllers
{
    public class AccountController : Controller
    {
        private ProdacDbContext context = new ProdacDbContext();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (
                    context.Kullanicis.Any(
                        x => x.KullaniciAdi == model.KullaniciAdi && x.Parola == model.Parola && x.IsDeleted == false))
                {
                    FormsAuthentication.SetAuthCookie(model.KullaniciAdi, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View();
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

    }
}