using System;
using System.Collections.Generic;

namespace da2.Models
{
    public partial class Table2
    {
        public Guid Id { get; set; }
        public int IdFromTable1 { get; set; }
        public Enums.CustomType2 Custom { get; set; }
    }
}
