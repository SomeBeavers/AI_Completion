using Cshtml.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cshtml.Controllers;

public class PersonController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View(
            new PersonViewModel()
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 25
            });
    }
}