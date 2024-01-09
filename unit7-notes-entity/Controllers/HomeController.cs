using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using unit7_notes_entity.Models;
using unit7_notes_entity.Services;

namespace unit7_notes_entity.Controllers;

public class HomeController : Controller
{
    private readonly ToDoContext _TodoContext;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, ToDoContext toDoContext)
    {
        _TodoContext = toDoContext;
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult Todos()
    {
        var todos = _TodoContext.ToDos.ToList();
        return View(todos);

    }

}

