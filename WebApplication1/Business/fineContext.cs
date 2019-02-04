using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Business
{
    public class fineContext : DbContext
    {
        public DbSet<fine_p> fines { get; set; }
    }
}