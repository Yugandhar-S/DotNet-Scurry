﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWeb.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Movies()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}
