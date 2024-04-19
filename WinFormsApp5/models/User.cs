using System;
using System.Collections.Generic;

namespace WinFormsApp5.models
{
    public partial class User
    {
        public User()
        {
            Activities = new HashSet<Activity>();
            Events = new HashSet<Event>();
            Marks = new HashSet<Mark>();
        }

        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public string? Email { get; set; }
        public DateTime? Birthday { get; set; }
        public int? CountryId { get; set; }
        public int? IdNumber { get; set; }
        public string? Password { get; set; }
        public string? Photo { get; set; }
        public int? GenderId { get; set; }
        public int? RoleId { get; set; }
        public int? CourseId { get; set; }
        public string? Phone { get; set; }
        public int Id { get; set; }

        public virtual Country? Country { get; set; }
        public virtual Course? Course { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual Role? Role { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
    }
}
