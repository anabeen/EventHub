using System;
using System.ComponentModel.DataAnnotations;

namespace EventHub.Models
{
    public class Event
    {
        public int Id { get; set; }

        public ApplicationUser Planner { get; set; }

        [Required]
        public string PlannerId { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Place { get; set; }

        public Theme EventTheme { get; set; }
        
        [Required]
        public int ThemeId { get; set; }
    }

    public class Theme
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}