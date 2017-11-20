using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCoreSample.Models;
using ASPNETCoreSample.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ASPNETCoreSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGreetingService _greetingService;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        public HomeController(IGreetingService greetingService, IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            _greetingService = greetingService;
            _configuration = configuration;
            _logger = loggerFactory.CreateLogger<HomeController>();
        }

        public string Hello(string id) => _greetingService.Greet(id);

        public string Setting1()
        {
            _logger.LogInformation("setting1 called");
            _logger.LogError("some error...");
            string setting1 = _configuration.GetSection("MySettingsGroup1")["MySetting1"];
            return setting1;
        }

        public string Setting2()
        {
            return _configuration.GetConnectionString("MyConnectionString");
        }

        public IActionResult Index()
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
