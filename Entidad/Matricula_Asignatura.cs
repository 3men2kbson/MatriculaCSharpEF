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
    
    public partial class Matricula_Asignatura
    {
        public Nullable<int> Cod_Matricula { get; set; }
        public int Cod_Asignatura { get; set; }
        public Nullable<float> Parametro_1 { get; set; }
        public Nullable<float> Parametro_2 { get; set; }
        public Nullable<float> Parametro_3 { get; set; }
        public Nullable<float> Parametro_4 { get; set; }
        public Nullable<float> Examen_Final { get; set; }
        public Nullable<float> Supletorio { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Cod_Distribucion { get; set; }
    
        public virtual Asignatura Asignatura { get; set; }
        public virtual Distribucion Distribucion { get; set; }
        public virtual Matricula Matricula { get; set; }
    }
}
