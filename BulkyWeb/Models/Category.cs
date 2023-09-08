﻿using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Range(1,100,ErrorMessage ="Display Order Must be between 1-100")]
        public int DisplayOreder { get; set; }
    }
}
