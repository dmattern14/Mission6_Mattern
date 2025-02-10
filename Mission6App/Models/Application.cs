using Microsoft.AspNetCore.Mvc;

namespace Mission6App.Models;

public class Application : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}