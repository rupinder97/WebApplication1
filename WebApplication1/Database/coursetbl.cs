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
    
    public partial class coursetbl
    {
        public coursetbl()
        {
            this.admissiontbls = new HashSet<admissiontbl>();
            this.finetbls = new HashSet<finetbl>();
        }
    
        public int Id { get; set; }
        public string Course { get; set; }
        public string Admfee { get; set; }
        public string Anualfee { get; set; }
    
        public virtual ICollection<admissiontbl> admissiontbls { get; set; }
        public virtual ICollection<finetbl> finetbls { get; set; }
    }
}
