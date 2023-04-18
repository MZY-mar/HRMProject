using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRM.MVC.Models;

namespace HRM.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;//already in dependency injection
      private readonly Serilog.Core.Logger log;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
      //  log = new Serilog.LoggerConfiguration().WriteTo.Console().CreateLogger();
    }

    public IActionResult Index()
    {
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
