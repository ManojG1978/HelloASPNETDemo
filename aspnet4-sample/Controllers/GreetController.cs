using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using aspnet4_sample.Models;

namespace aspnet4_sample.Controllers
{
    public class GreetController : Controller
    {
    // GET: Greet
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Greet(GreetModel model)
        {
            if (!string.IsNullOrEmpty(model.Name))
            {
                model.Greeting = "Hello! " + model.Name;
            }
            return View("Index", model);
        }
    }
}