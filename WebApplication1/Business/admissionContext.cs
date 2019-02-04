using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Business
{
    
    public class admissionContext : DbContext
    { 
        
        public DbSet<admission_stud> admissions { get; set; }
    }
}