using System;
using System.Collections.Generic;

namespace WinFormsApp5.models
{
    public partial class Country
    {
        public Country()
        {
            Users = new HashSet<User>();
        }

        public string? Title { get; set; }
        public string? EnglishTitle { get; set; }
        public string? Code { get; set; }
        public int? Code2 { get; set; }
        public int Id { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
