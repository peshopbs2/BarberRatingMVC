using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BarberRatingMVC.Models;
using BarberRatingMVC.Data;

namespace BarberRatingMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        ViewData["Barbers"] = _context.Barber.Count();
        ViewData["Reviews"] = _context.Review.Count();
        ViewData["Users"] = _context.Users.Count();

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
