using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleMVCApp.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        

    }
}
