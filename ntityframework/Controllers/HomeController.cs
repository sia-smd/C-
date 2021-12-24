using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ntityframework.Models;
using Microsoft.Extensions.Configuration;
namespace ntityframework.Controllers;

public class HomeController : Controller
{
    public IConfiguration  k;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var b=k["name"];
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
