using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Business
{
    public class admission_stud
    {
        public int id { get; set; }
        public int Rollno { get; set; }
        public string Name { get; set; }
        public string Father { get; set; }
        public Nullable<System.DateTime> Dod { get; set; }
        public string Contactno { get; set; }
        public string Session_year { get; set; }
        public string Course { get; set; }
        public Nullable<int> Fee_rec { get; set; }

        public Nullable<System.DateTime> Doa { get; set; }


    }
}