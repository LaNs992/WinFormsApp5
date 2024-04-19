using System;
using System.Collections.Generic;

namespace WinFormsApp5.models
{
    public partial class Gender
    {
        public Gender()
        {
            Users = new HashSet<User>();
        }

        public string? Title { get; set; }
        public int Id { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
