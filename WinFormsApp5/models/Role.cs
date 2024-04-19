using System;
using System.Collections.Generic;

namespace WinFormsApp5.models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public string? Title { get; set; }
        public int Id { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
