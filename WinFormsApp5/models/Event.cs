using System;
using System.Collections.Generic;

namespace WinFormsApp5.models
{
    public partial class Event
    {
        public Event()
        {
            Activities = new HashSet<Activity>();
        }

        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public int? Days { get; set; }
        public int? CityId { get; set; }
        public int? CourseId { get; set; }
        public int? WinnerId { get; set; }
        public string? Logo { get; set; }
        public int Id { get; set; }

        public virtual City? City { get; set; }
        public virtual Course? Course { get; set; }
        public virtual User? Winner { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
