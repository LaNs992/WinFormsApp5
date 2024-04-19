using System;
using System.Collections.Generic;

namespace WinFormsApp5.models
{
    public partial class City
    {
        public City()
        {
            Events = new HashSet<Event>();
        }

        public string? Title { get; set; }
        public string? CostOfArms { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
