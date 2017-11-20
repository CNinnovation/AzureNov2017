using Microsoft.Extensions.DependencyInjection;
using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterServices();
            CallController();
        }

        private static void CallController()
        {
            var controller = Container.GetRequiredService<HomeController>();
            string message = controller.Hello("Matthias");
            Console.WriteLine(message);
        }

        //private static void CallController()
        //{
        //    var controller = new HomeController(new GreetingService());
        //    string message = controller.Hello("Stephanie");
        //    Console.WriteLine(message);
        //}



        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IGreetingService, GreetingService>();
            services.AddTransient<HomeController>();
            Container = services.BuildServiceProvider();
        }

        public static IServiceProvider Container { get; private set; }
    }
}
