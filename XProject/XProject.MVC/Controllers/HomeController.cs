using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Diagnostics;
using XProject.Application.Interfaces;
using XProject.Domain;
using XProject.Domain.Enums;
using XProject.MVC.Filters;
using XProject.MVC.Models;

namespace XProject.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAppPageService _appPageService;                

        public HomeController(ILogger<HomeController> logger, IAppPageService appPageService)
        {
            _logger = logger;
            _appPageService = appPageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [CheckAppPageVisibility(AppPageEnum.Privacy)]
        public IActionResult Privacy()
        {
            return View();
        }

        [RandomAccessFilter]
        public IActionResult RandomPage()
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