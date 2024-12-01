using Microsoft.AspNetCore.Mvc;
using ActivityTracker.Models;

namespace ActivityTracker.Controllers;

public class ActivityController : Controller
{
    private readonly AppDbContext _context;
    
    public ActivityController(AppDbContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        var activities = _context.Activities.ToList();
        return View(activities);
    }
    
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(ATActivity activity)
    {
        if (!ModelState.IsValid) return View(activity);
        activity.Date = DateTime.Now;
        _context.Activities.Add(activity);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}