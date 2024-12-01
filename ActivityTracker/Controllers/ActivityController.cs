using Microsoft.AspNetCore.Mvc;
using ActivityTracker.Models;

namespace ActivityTracker.Controllers;

public class ActivityController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}