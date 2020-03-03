using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EMart.BusinessLayer.Services;
using EMart.DataLayer;
using EMart.Entities;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        private readonly BuyerServices _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();


        public HomeController()
        {
            _service = new BuyerServices(_session);
        }
        public ActionResult Index()
        {
             return View();

            
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
