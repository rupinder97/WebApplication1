using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Business
{
    public class fine_p
    {
        public int Id { get; set; }
        public Nullable<int> Rollno { get; set; }
        public string course { get; set; }
        public Nullable<System.DateTime> Lastdate { get; set; }
        public Nullable<int> Fine { get; set; }
    }
}