using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "India",
                "IS",
                "UK",
                "Canada"
            };
            return View();

        }


    }
}