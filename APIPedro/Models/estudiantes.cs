//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIPedro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class estudiantes
    {
        public estudiantes()
        {
            this.calificaciones = new HashSet<calificaciones>();
        }
    
        public string CeduEstu { get; set; }
        public string NombEstu { get; set; }
        public string ApelEstu { get; set; }
        public Nullable<int> RolEstu { get; set; }
        public string FacuEstu { get; set; }
        public string ProgEstu { get; set; }
        public Nullable<int> Semestre { get; set; }
        public string Login_Usuario { get; set; }
    
        public virtual ICollection<calificaciones> calificaciones { get; set; }
        public virtual login login { get; set; }
    }
}
