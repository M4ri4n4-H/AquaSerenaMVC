using Microsoft.AspNetCore.Mvc;
using AquaSerena.Models;

namespace AquaSerena.Controllers;

public class ReservaController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new Reserva());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(Reserva reserva)
    {
        if (!ModelState.IsValid)
        {
            return View(reserva);
        }

        return View("Resultado", reserva);
    }
}
