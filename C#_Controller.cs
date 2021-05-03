using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTest01.Controllers
{
    public class StudyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// IAR = IActionResult
        /// </summary>
        public IActionResult Java()
        {
            return View();
        }

        public IActionResult CSharp()
        {
            return View();
        }

        public IActionResult Cpp()
        {
            return View();
        }
    }
}
