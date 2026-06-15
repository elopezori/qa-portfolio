using Microsoft.AspNetCore.Mvc;
using UserManagementApp.Models;

namespace UserManagementApp.Controllers;

public class UsersController : Controller
{
    public IActionResult Index()
    {
        var users = new List<User>
        {
            new User { Id = 1, Name = "Juan", Email = "juan@test.com" },
            new User { Id = 2, Name = "Ana", Email = "ana@test.com" }
        };

        return View(users);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(User user)
    {
        if (!ModelState.IsValid)
        {
            return View(user);
        }

        return RedirectToAction(nameof(Index));
    }
}