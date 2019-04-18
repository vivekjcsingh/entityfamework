using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace testentityframework.Models
{
    public class StudentNewDBontext : DbContext
    {        
        public virtual DbSet<Student> Students { get; set; }
    }
}