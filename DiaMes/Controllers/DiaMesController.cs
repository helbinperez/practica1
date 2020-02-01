using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DiaMes.Controllers
{
    public class DiaMesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dato()
        {
            return View();
        }
    }
}