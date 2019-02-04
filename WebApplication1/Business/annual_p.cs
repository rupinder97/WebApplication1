using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Business
{
    public class annual_p
    {
        public int Id { get; set; }
        public Nullable<int> Rollno { get; set; }
        public string Feetype { get; set; }
        public Nullable<int> Fees { get; set; }
        public Nullable<int> Latefee { get; set; }
        public Nullable<int> Feerec { get; set; }
        public Nullable<System.DateTime> Dor { get; set; }

    }
}