using Microsoft.AspNetCore.Mvc;

namespace ProvaSoftware.Controllers;

public class Prova : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}