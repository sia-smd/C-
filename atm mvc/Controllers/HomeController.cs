using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using atm_mvc.Models;
using atm_mvc;

namespace atm_mvc.Controllers
{
    public class HomeController : Controller
    {
       protected readonly connect _connect;
       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,connect connect)
        {
            _logger = logger;
            _connect=connect;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult check(account a)
        {
           var c=_connect.account.Where(x=>x.Password==a.Password && x.Account_number==a.Account_number).Singleordefault();
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
