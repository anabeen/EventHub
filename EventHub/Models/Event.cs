using System;
using System.ComponentModel.DataAnnotations;

namespace EventHub.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Planner { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Place { get; set; }

        [Required]
        public Theme EventTheme { get; set; }
    }

    public class Theme
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}