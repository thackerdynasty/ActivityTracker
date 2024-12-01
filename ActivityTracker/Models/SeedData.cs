using Microsoft.EntityFrameworkCore;

namespace ActivityTracker.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider provider)
    {
        using var context = new AppDbContext(provider.GetRequiredService<DbContextOptions<AppDbContext>>());
        if (context.Activities.Any())
        {
            return;
        }
        context.Activities.AddRange(
            new ATActivity
            {
                Name = "Dummy1",
                Date = DateTime.Now,
                Description = "Dummy"
            },
            new ATActivity
            {
                Name = "Dummy2",
                Date = DateTime.Now,
                Description = "Dummy"
            },
            new ATActivity
            {
                Name = "Dummy3",
                Date = DateTime.Now,
                Description = "Dummy"
            }
        );
        context.SaveChanges();
    }
}