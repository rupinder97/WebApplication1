using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Business
{
    public class annualContext : DbContext
    {
        public DbSet<annual_p> annuals { get; set; }
    }
}