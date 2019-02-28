using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacExample.Models
{
    public class StudentViewModel
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string DateOfBirth { get; set; }

        public decimal Height { get; set; }
        public float Weight { get; set; }
    }
}