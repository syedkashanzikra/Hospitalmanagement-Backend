using System;
using System.Collections.Generic;

namespace Hospital_Management_Backend.Models
{
    public partial class Exam
    {
        public int ExamId { get; set; }
        public string SubjectName { get; set; } = null!;
        public DateTime ExamDate { get; set; }
    }
}
