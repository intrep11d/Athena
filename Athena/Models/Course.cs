using System;
using System.ComponentModel.DataAnnotations;

namespace Athena.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string? Title { get; set; }

        [Required]
        [StringLength(500)]
        public string? Description { get; set; }

        // You can add more properties as needed, for example:
        public string? Category { get; set; }
        public int Duration { get; set; } // Duration in minutes or hours
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        // Add a property for the content if you want to store it directly in the database
        // public string Content { get; set; }

        // If you're storing files, you might want a collection of resources
        // public virtual ICollection<Resource> Resources { get; set; }
    }
}

