using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using AddressBook.Interfaces;
using Microsoft.Extensions.Localization;
using AddressBook.Resources;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        private ItimeProvider timeProvider;
        private readonly IStringLocalizerFactory factory;
        private readonly IStringLocalizer localizer;

        public HomeController(ItimeProvider _timeProvider, IStringLocalizerFactory factory)
        {
            timeProvider = _timeProvider;
            this.factory = factory;
            localizer = factory.Create(typeof(SharedResource));
        }

        
        public IActionResult Index()
        {
            ViewBag.Time = timeProvider.Now.ToString();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = localizer["About"];

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Cool()
        {
            CoolViewModel m = new CoolViewModel { CoolMessage = "Really nice message" };
            return View(m);
        }
    }
}
