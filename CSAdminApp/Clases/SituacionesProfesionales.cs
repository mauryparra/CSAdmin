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
    
    public partial class SituacionesProfesionales
    {
        public SituacionesProfesionales()
        {
            this.Contratos = new HashSet<Contratos>();
        }
    
        public string CargoAbrev { get; set; }
        public string Cargo { get; set; }
        public string CondicionAbrev { get; set; }
        public string Condicion { get; set; }
    
        public virtual ICollection<Contratos> Contratos { get; set; }
    }
}
