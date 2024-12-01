using Microsoft.EntityFrameworkCore;

namespace ActivityTracker.Models;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<ATActivity> Activities { get; set; }
}