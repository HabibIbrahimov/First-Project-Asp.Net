using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var view = new ViewResult();
            //view.ViewName = "Index";
            //return view;
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult GetFile()
        {
            return File("~/img/image.jpeg", "image/jpg");
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
