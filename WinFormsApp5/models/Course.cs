using System;
using System.Collections.Generic;

namespace WinFormsApp5.models
{
    public partial class Course
    {
        public Course()
        {
            Events = new HashSet<Event>();
            Users = new HashSet<User>();
        }

        public string? EventTitle { get; set; }
        public string? CourseId { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
