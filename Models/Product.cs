﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PosApplication.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [Display(Name= "Category")]
        public int? CategoryId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }

        public Category? Category { get; set; }
    }
}
