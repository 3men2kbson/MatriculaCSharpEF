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
    
    public partial class Pai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pai()
        {
            this.Personas = new HashSet<Persona>();
        }
    
        public string PaisCodigo { get; set; }
        public string PaisNombre { get; set; }
        public string PaisContinente { get; set; }
        public string PaisRegion { get; set; }
        public double PaisArea { get; set; }
        public Nullable<short> PaisIndependencia { get; set; }
        public int PaisPoblacion { get; set; }
        public Nullable<double> PaisExpectativaDeVida { get; set; }
        public Nullable<double> PaisProductoInternoBruto { get; set; }
        public Nullable<double> PaisProductoInternoBrutoAntiguo { get; set; }
        public string PaisNombreLocal { get; set; }
        public string PaisGobierno { get; set; }
        public string PaisJefeDeEstado { get; set; }
        public Nullable<int> PaisCapital { get; set; }
        public string PaisCodigo2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona> Personas { get; set; }
    }
}