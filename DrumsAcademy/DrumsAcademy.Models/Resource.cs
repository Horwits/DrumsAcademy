using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DrumsAcademy.Common.Enums;

namespace DrumsAcademy.Models
{
    public class Resource
    {
        public Guid Id { get; set; }

        public string Author { get; set; } // this has to be user ->

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Title { get; set; }

        [Required]
        public ResourceType Type { get; set; }

        [Required]
        public LevelType Level { get; set; }

        [Required]
        public string Url { get; set; }

        public virtual Category Category { get; set; }

        public Guid CategoryId { get; set; }
    }
}