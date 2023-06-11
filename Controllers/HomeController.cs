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
        ViewBag.Error="";
        if (sala==escape.GetEstadoJuego()){
            bool claveCorrecta=escape.resolverSala(sala, clave);
            if (!claveCorrecta) ViewBag.Error="La clave ingresada no es correcta";
            if ((sala==4)&&(claveCorrecta)) return View("victoria");
            else return Comenzar();
        }
        else return Comenzar(); 
    }
    public IActionResult Pistas(int sala)
    {
        ViewBag.Pista="";
        if (sala==1) ViewBag.Pista="La clave es una letra de cada palabra. (Tocá el boton '+ Resultados' para ver las palabras.)";
        if (sala==2) ViewBag.Pista="En esta sopa de letras hay una palabra fuera de contexto... (Tocá el boton '+ Resultados' para ver las palabras.)";
        if (sala==3) ViewBag.Pista="";
        if (sala==4) ViewBag.Pista="";
        return Comenzar();
    }
    public IActionResult Solucion(int sala)
    {
        ViewBag.Clave="";
        if (sala==1) ViewBag.Clave="La clave es una letra de cada palabra. (Tocá el boton '+ Resultados' para ver las palabras.)";
        if (sala==2) ViewBag.Pista="En esta sopa de letras hay una palabra fuera de contexto... (Tocá el boton '+ Resultados' para ver las palabras.)";
        if (sala==3) ViewBag.Pista="";
        if (sala==4) ViewBag.Pista="";
        return Comenzar();
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
