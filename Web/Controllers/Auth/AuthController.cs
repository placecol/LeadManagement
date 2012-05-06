﻿using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Kaiser.LeadManagement.Web.Infrastructure.Raven;
using Kaiser.LeadManagement.Web.Models;
using Raven.Client;

namespace Kaiser.LeadManagement.Web.Controllers.Auth
{
    public class AuthController : Controller
    {
        private readonly IDocumentSession db = DocumentStoreHolder.Store.OpenSession();

        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(Login model, string returnUrl)
        {
            var helper = new HtmlHelper<object>(new ViewContext(), new ViewPage());

            User user;
            if (!AreCredentialsValid(model.Email, model.Password, out user))
            {
                ModelState.AddModelError(string.Empty, "Incorrect username or password");
                return View();
            }

            FormsAuthentication.SetAuthCookie(user.AspNetUserGuid, model.Persistent);
            return Redirect(returnUrl ?? "~/");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        private bool AreCredentialsValid(string email, string password, out User user)
        {
            user = db.Query<User>().FirstOrDefault(p => p.Email == (email).Trim());

            if (user == null) return false;

            return user.TryPassword(password);
        }
    }
}