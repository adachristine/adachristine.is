using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AdaChristine.Sandbox.Web.Models;
using System.Net;

namespace AdaChristine.Sandbox.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [Route("/HttpError/{statusCode}")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult HttpError(System.Net.HttpStatusCode statusCode)
    {
        return View(new ErrorViewModel { StatusCode = statusCode, RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
