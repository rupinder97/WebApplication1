using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Business
{
    public class courseContext : DbContext
    {
        public DbSet<course_p> courses { get; set; }
    }
}