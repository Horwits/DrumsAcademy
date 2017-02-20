using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using DrumsAcademy.Common.Enums;

namespace DrumsAcademy.Models
{
    public class Category
    {
        public Category()
        {
            this.Resources = new HashSet<Resource>();
        }

        public Guid Id { get; set; }

        [Required]
        public CategoryType Type { get; set; }

        public virtual IEnumerable<Resource> Resources { get; set; }
    }
}