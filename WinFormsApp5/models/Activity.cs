using System;
using System.Collections.Generic;

namespace WinFormsApp5.models
{
    public partial class Activity
    {
        public Activity()
        {
            Marks = new HashSet<Mark>();
        }

        public int? EventId { get; set; }
        public string? Title { get; set; }
        public int? Day { get; set; }
        public DateTime? TimeStart { get; set; }
        public int? ModeratorId { get; set; }
        public int Id { get; set; }

        public virtual Event? Event { get; set; }
        public virtual User? Moderator { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
    }
}
