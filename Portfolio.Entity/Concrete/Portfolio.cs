using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity.Concrete;

public class Portfolio
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
}