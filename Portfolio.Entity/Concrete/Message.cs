using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity.Concrete;

public class Message
{
    [Key]
    public int Id { get; set; }
    public string SenderName { get; set; }
    public string Mail { get; set; }
    public string Content { get; set; }
    public DateTime SendAt { get; set; }
    public bool Status { get; set; }

}