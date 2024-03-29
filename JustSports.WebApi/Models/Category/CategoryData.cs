﻿using System.ComponentModel.DataAnnotations;

namespace JustSports.WebApi.Models
{
    public class CategoryData
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        
    }
}
