//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class admissiontbl
    {
        public admissiontbl()
        {
            this.annualtbls = new HashSet<annualtbl>();
        }
    
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
    
        public virtual coursetbl coursetbl { get; set; }
        public virtual ICollection<annualtbl> annualtbls { get; set; }
    }
}