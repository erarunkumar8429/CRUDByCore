using System.Diagnostics;
using DemoOfDI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DemoOfDI.Controllers
{
    public class HomeController : Controller
    {
      private  readonly IMessageService _messageService;

		public HomeController(IMessageService messsageservice)
		{
			    _messageService = messsageservice;
		}
        public void NotifyUser()
        {
			Console.WriteLine("Welcome to Dependency Injection Demo !");
        }
		public IActionResult Index()
        {
            string txt = _messageService.SendMessage();
			Console.WriteLine(txt);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
