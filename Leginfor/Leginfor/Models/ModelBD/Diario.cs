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
    
    public partial class Diario
    {
        public decimal do_Id { get; set; }
        public System.DateTime do_Fecha { get; set; }
        public bool do_Activo { get; set; }
        public bool do_dividido { get; set; }
        public bool do_entero { get; set; }
        public bool do_pdf { get; set; }
        public Nullable<bool> do_ent_div { get; set; }
        public bool do_conv_act { get; set; }
        public bool do_Tema { get; set; }
        public string do_Entero_LG { get; set; }
        public bool do_pdf_LG { get; set; }
        public bool do_ent_div_LG { get; set; }
        public bool do_conv_act_LG { get; set; }
        public bool do_Tema_LG { get; set; }
    }
}