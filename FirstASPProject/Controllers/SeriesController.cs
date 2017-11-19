using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstASPProject.Models;

namespace FirstASPProject.Controllers
{
    public class SeriesController : Controller
    {
        // GET: Series
        public ActionResult Random()
        {
            var series = new Series() { Name = "Silicon Valley" };

            return View(series);
        }
    }
}