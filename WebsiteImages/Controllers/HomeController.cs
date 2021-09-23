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

            return View();
        }
    }
}