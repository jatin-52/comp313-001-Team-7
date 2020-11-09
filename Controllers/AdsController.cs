using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SecondHandBook.Controllers
{
    public class AdsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateAd()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAd(IFormCollection collection)
        {
            return RedirectToAction("CreateAd");
        }

        [HttpGet]
        public IActionResult ListAds()
        {
            return View();
        }

    }
}
