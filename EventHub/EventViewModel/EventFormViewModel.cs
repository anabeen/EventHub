using EventHub.EventViewModelDateValidation;
using EventHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventHub.EventFormViewModel
{
    public class EventViewModel
    {
        [Required]
        public string Place { get; set; }

        [Required]
        [DateValidation]
        public string Date { get; set; }

        [Required]
        [TimeValidation]
        public string Time { get; set; }

        [Required]
        public int Theme { get; set; }
        public IEnumerable<Theme> Themes { get; set; }

        public DateTime dateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}