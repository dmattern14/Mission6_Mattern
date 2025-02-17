using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6App.Models;

namespace Mission6App.Controllers;

public class HomeController : Controller

{
    private MovieFormContext _context;

    public HomeController(MovieFormContext temp) //constructor
    {
        _context = temp;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Form(Application response)
    {
        _context.Forms.Add(response); //Add record to Database
        _context.SaveChanges();
        
        return View("FormConfirmation", response);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}