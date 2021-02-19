using EventHub.Models;
using System.Collections.Generic;

namespace EventHub.EventFormViewModel
{
    public class EventViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Theme { get; set; }
        public IEnumerable<Theme> Themes { get; set; }
    }
}