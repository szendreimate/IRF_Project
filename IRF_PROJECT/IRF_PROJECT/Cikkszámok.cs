//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IRF_PROJECT
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cikkszámok
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cikkszámok()
        {
            this.Tárhelyek = new HashSet<Tárhelyek>();
        }
    
        public int Id { get; set; }
        public int cikkszam { get; set; }
        public string marka { get; set; }
        public string méret { get; set; }
        public string ruhatipus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tárhelyek> Tárhelyek { get; set; }
    }
}
