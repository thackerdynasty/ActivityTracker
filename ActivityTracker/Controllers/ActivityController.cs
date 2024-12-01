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
        _context.Activities.Add(activity);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    public IActionResult Delete(int id)
    {
        var activity = _context.Activities.Find(id);
        if (activity == null) return NotFound();
        _context.Activities.Remove(activity);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    public IActionResult Edit(int id)
    {
        var activity = _context.Activities.Find(id);
        if (activity == null) return NotFound();
        return View(activity);
    }
    
    [HttpPost]
    public IActionResult Edit(ATActivity activity)
    {
        if (!ModelState.IsValid) return View(activity);
        _context.Activities.Update(activity);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}