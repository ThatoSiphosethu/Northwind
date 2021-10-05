using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System.Linq;
using System;

namespace Northwind.Controllers
{
    public class DiscountController : Controller
    {
        private NorthwindContext _NorthwindContext;

        public DiscountController(NorthwindContext db) => _NorthwindContext = db;

        public ActionResult Product() => View(_NorthwindContext.Discounts);
    }
}