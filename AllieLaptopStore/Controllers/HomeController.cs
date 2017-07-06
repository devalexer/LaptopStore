using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using AllieLaptopStore.Models;

namespace AllieLaptopStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }

    }
}