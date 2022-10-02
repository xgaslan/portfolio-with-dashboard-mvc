﻿using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity.Concrete;

public class Contact
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }
}