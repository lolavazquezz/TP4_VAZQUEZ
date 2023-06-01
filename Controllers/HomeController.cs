using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP5_VAZQUEZ.Models;

namespace TP5_VAZQUEZ.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Index");
    }
    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }
    public IActionResult Comenzar()
    {
        string sala="sala" + escape.GetEstadoJuego();
        return View(sala);
    }
    public IActionResult Habitacion(int sala, string clave)
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
