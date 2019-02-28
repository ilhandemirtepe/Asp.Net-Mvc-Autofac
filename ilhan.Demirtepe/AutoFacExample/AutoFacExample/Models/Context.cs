using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutoFacExample.Models
{
    public class Context : DbContext
    {
        public Context() : base("Context") { }
     
        public virtual DbSet<Student> Students { get; set; }
    }
}