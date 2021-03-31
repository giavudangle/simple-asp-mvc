using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleMVCApp.Controllers
{
    public class MobileStoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListProducts(){
            return View("MobileList");
        }

    }
}
