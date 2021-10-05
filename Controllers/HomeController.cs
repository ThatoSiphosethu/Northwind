using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;


namespace Northwind.Controllers
{
    public class HomeController : Controller
    
    {
        private NorthwindContext _northwindContext;
        public HomeController(NorthwindContext db) => _northwindContext = db;

        public ActionResult Index() => View(_northwindContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now).Take(3));

        // public IActionResult(int id){
        //     //show the toast
        //     {
        //         return showToast();
        //     }
        // }
        
    }

    

    
}