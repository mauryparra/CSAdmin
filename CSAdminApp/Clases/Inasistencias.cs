//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSAdminApp.Clases
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inasistencias
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public System.DateTime Desde { get; set; }
        public Nullable<System.DateTime> Hasta { get; set; }
        public string Motivo { get; set; }
    
        public virtual Personas Personas { get; set; }
    }
}
