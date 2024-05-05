using System;
using System.Collections.Generic;

namespace Hospital_Management_Backend.Models
{
    public partial class Student
    {
        public int SId { get; set; }
        public string SName { get; set; } = null!;
        public string SGender { get; set; } = null!;
        public int SAge { get; set; }
        public string SFathername { get; set; } = null!;
    }
}
