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
    
    public partial class Contratos
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public string Origen { get; set; }
        public string CargoId { get; set; }
        public string CondicionId { get; set; }
        public string FuncionId { get; set; }
        public string EquipoId { get; set; }
        public byte Horas { get; set; }
        public string Observacion { get; set; }
    
        public virtual Equipos Equipos { get; set; }
        public virtual Funciones Funciones { get; set; }
        public virtual Personas Personas { get; set; }
        public virtual SituacionesProfesionales SituacionesProfesionales { get; set; }
    }
}