using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leginfor.Models.Index
{
    public class Relevantes
    {
        public string Ver { get; set; }
		public decimal Id { get; set; }
		public int SeccId { get; set; }
		public string SeccNombre { get; set; }
		public DateTime NotiPublicacion { get; set; }
		public DateTime Publicacion { get; set; }
		public string Titulo { get; set; }
		public string Fuente { get; set; }
		public string Resumen { get; set; }
		public int Estado { get; set; }
		public string Vinculo { get; set; }
    }
}