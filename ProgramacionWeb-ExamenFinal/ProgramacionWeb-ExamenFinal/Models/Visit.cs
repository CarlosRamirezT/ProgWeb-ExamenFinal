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
    
    public partial class Visit
    {
        public int idVisit { get; set; }

        [DisplayName("Fecha")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> date { get; set; }

        [DisplayName("Hora Entrada")]
        [DataType(DataType.Time)]
        public Nullable<System.TimeSpan> entranceTime { get; set; }

        [DisplayName("Hora Salida")]
        [DataType(DataType.Time)]
        public Nullable<System.TimeSpan> departureTime { get; set; }

        [DisplayName("Nombre Completo")]
        [DataType(DataType.Text)]
        public string fullname { get; set; }

        [DisplayName("Contacto Atendio")]
        [DataType(DataType.Text)]
        public int idContact { get; set; }
    
        public virtual Contact Contact { get; set; }
    }
}