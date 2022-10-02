﻿using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity.Concrete;

public class Testimonial
{
    [Key]
    public int Id { get; set; }
    public string Client { get; set; }
    public string Company { get; set; }
    public string Comment { get; set; }
    public string ImageUrl { get; set; }
}