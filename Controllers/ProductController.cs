using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System.Linq;

namespace Northwind.Controllers
{
     public class ProductController : Controller
    {
        private NorthwindContext _NorthwindContext;

        public ProductController(NorthwindContext db) => _NorthwindContext = db;

        public IActionResult Discount() => View(_NorthwindContext.Discounts.OrderBy(c => c.Title));

        public IActionResult Category() => View(_NorthwindContext.Categories.OrderBy(b => b.CategoryName));

       public IActionResult Index(int id){
            ViewBag.id = id;
            return View(_NorthwindContext.Categories.OrderBy(c => c.CategoryName));
        }
    }
}
