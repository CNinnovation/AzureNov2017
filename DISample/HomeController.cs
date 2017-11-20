using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    public class HomeController
    {
        private readonly IGreetingService _greetingService;
        public HomeController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public string Hello(string name)
        {
            // var service = new GreetingService();
            //  string message = service.Greet(name);
            string message = _greetingService.Greet(name);
            return message;
        }
    }
}
