﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionApp.Controllers
{
    public class SessionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}