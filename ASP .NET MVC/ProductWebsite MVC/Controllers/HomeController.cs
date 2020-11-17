using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductWebsite.Models;

namespace ProductWebsite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        ProductLayer p1 = new ProductLayer();
        public ActionResult Index()
        {

            return View(p1.Products);
        }

    }
}
