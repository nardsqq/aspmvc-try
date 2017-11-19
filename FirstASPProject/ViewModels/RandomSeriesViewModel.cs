using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstASPProject.Models;

namespace FirstASPProject.ViewModels
{
    public class RandomSeriesViewModel
    {
        public Series Series { get; set; }
        public List<Customer> Customers { get; set; }
    }
}