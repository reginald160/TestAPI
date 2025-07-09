﻿using System.ComponentModel.DataAnnotations;

namespace TestAPI.Domain
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Author { get; set; }
        
        public string? Category { get; set; }
        public decimal Price { get; set; }
    }
}
