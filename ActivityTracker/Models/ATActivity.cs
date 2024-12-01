using System.ComponentModel.DataAnnotations;

namespace ActivityTracker.Models;

public class ATActivity
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Description { get; set; }
    
    [Required]
    public DateTime Date { get; set; }
}