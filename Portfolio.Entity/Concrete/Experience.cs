using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity.Concrete;

public class Experience
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime StartedAt { get; set; }
    public DateTime FinishedAt { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}