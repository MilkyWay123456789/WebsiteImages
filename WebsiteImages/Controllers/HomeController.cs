using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteImages.Models;


namespace WebsiteImages.Controllers
{
    public class HomeController : Controller
    {
        ImagesEntities db = new ImagesEntities();
        public ActionResult Index()
        {
            List<WebsiteImages.Models.Image> NewImage = db.Images.OrderByDescending(n => n.CreatedDate).Take(8).ToList();
            ViewBag.NewImage = NewImage;
            List<WebsiteImages.Models.Image> PopularImage = db.Images.OrderByDescending(p=>p.Views).Take(8).ToList();
            ViewBag.PopularImage = PopularImage;
            return View();
        }
    }
}