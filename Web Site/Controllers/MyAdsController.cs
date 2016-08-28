using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Web_Site.Models;
using System.Web.UI.WebControls;
using System.Collections;

namespace Web_Site.Controllers
{
    public class MyAdsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MyAds
        [Authorize]
        public ActionResult Index()
        {
            var currentUserId = User.Identity.GetUserId();
            var listings = db.Listings.Where(l => l.Author_Id.ToString() == currentUserId).ToList();
            return View(listings);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
