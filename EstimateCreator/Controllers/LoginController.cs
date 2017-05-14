using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstimateCreator.Models;
using DataAccessLayer;
using System.Configuration;

namespace EstimateCreator.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult ValidateUser(UserDetail userDetails)
        {
            //string cs = ConfigurationManager.ConnectionStrings["EstimatorDbContext"].ConnectionString;
            //EstimatorDbContext db = new EstimatorDbContext();
            ValidateLogin vdal = new ValidateLogin();
            if (vdal.Validate(userDetails))
            {
                ViewBag.Message = "successful login";
                //RedirectTo
            }
            else
            {
                ViewBag.Message = "Login failure";
            }

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}