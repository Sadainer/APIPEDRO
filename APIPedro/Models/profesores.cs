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
    
    public partial class profesores
    {
        public profesores()
        {
            this.asignaturas = new HashSet<asignaturas>();
        }
    
        public string CeduProf { get; set; }
        public string NombProf { get; set; }
        public string ApelProf { get; set; }
        public Nullable<int> RolProf { get; set; }
        public string FacuProf { get; set; }
        public string ProgProf { get; set; }
        public string Login_Usuario { get; set; }
    
        public virtual ICollection<asignaturas> asignaturas { get; set; }
        public virtual login login { get; set; }
    }
}
