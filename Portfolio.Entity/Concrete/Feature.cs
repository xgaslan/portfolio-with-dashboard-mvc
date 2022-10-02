using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity.Concrete;

public class Feature
{
    [Key]
    public int Id { get; set; }
    public string Header { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
}