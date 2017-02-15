using System;
using System.ComponentModel.DataAnnotations;
using DrumsAcademy.Common.Enums;

namespace DrumsAcademy.Models
{
    public class Resource
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public ResourceType Type { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        [MinLength(50)]
        [MaxLength(500)]
        public string Title { get; set; }

        [Required]
        [MinLength(50)]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public string Author { get; set; } // this has to be user ->
    }
}
