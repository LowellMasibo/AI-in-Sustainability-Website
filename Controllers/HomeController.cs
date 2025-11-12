using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcWebSite.Models;
using AspNetCoreMvcWebSite.Data;


namespace AspNetCoreMvcWebSite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController>? _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }
    public IActionResult Index()
    {
        IEnumerable<AIImages> images = _context.AIImages.ToList();

        return View(images);
    }

    public IActionResult Future()
    {
    return View();
    }


    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
