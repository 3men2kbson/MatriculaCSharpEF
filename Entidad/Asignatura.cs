//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asignatura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asignatura()
        {
            this.Distribucions = new HashSet<Distribucion>();
            this.Matricula_Asignatura = new HashSet<Matricula_Asignatura>();
        }
    
        public int Cod_Asignatura { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Nro_Horas { get; set; }
        public Nullable<float> Nro_Creditos { get; set; }
        public Nullable<int> Asignatura_Previa { get; set; }
        public int Cod_Carrera { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Distribucion> Distribucions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matricula_Asignatura> Matricula_Asignatura { get; set; }
    }
}
