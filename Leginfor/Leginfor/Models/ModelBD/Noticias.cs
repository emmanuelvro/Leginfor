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
    
    public partial class Noticias
    {
        public decimal noti_Id { get; set; }
        public int secc_Id { get; set; }
        public System.DateTime noti_Publicacion { get; set; }
        public string noti_Titulo { get; set; }
        public string noti_Contenido { get; set; }
        public string noti_Fuente { get; set; }
        public string noti_resumen { get; set; }
        public int noti_Estado { get; set; }
        public bool noti_Activo { get; set; }
        public string user_Id { get; set; }
        public System.DateTime est_Actualizado { get; set; }
        public bool Seguridad { get; set; }
        public string Vinculo { get; set; }
        public string noti_imagen { get; set; }
        public bool noti_scroll { get; set; }
    }
}
