//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Leginfor.Models.ModelBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Destacado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Destacado()
        {
            this.Extraordinarios = new HashSet<Extraordinario>();
        }
    
        public int des_id { get; set; }
        public string Nombre { get; set; }
        public string Destacado1 { get; set; }
        public System.DateTime fec_alt { get; set; }
        public Nullable<System.DateTime> fec_baj { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Extraordinario> Extraordinarios { get; set; }
    }
}
