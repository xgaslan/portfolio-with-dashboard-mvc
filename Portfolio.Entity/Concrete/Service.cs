using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity.Concrete;

public class Service
{
    [Key]
    public int Id { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
}