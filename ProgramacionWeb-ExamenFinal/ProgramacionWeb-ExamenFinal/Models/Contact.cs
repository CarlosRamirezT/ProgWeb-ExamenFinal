//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgramacionWeb_ExamenFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Contact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contact()
        {
            this.Visits = new HashSet<Visit>();
        }
    
        public int idContact { get; set; }

        [DisplayName("Nombre Atendio")]
        public string name { get; set; }

        [DisplayName("Apellido")]
        public string lastname { get; set; }

        [DisplayName("Cedula")]
        public string idCard { get; set; }

        [DisplayName("Fecha Creacion")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> creationDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visit> Visits { get; set; }
    }
}