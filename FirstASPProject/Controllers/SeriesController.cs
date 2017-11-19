using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstASPProject.Models;
using FirstASPProject.ViewModels;

namespace FirstASPProject.Controllers
{
    public class SeriesController : Controller
    {
        // GET: Series
        public ActionResult Random()
        {
            var series = new Series() { Name = "Silicon Valley" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var ViewModel = new RandomSeriesViewModel
            {
                Series = series,
                Customers = customers
            };

            return View(ViewModel);    
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}