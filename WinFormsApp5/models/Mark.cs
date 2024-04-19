using System;
using System.Collections.Generic;

namespace WinFormsApp5.models
{
    public partial class Mark
    {
        public int? JuriId { get; set; }
        public int? ActivityId { get; set; }
        public int Id { get; set; }

        public virtual Activity? Activity { get; set; }
        public virtual User? Juri { get; set; }
    }
}
