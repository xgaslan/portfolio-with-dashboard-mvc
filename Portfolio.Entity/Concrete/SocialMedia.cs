using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity.Concrete;

public class SocialMedia
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
    public bool Status { get; set; }
}