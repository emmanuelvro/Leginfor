using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leginfor.Models.Index
{
    public class Dof
    {
        public decimal Id { get; set;  }
        public DateTime Fecha { get; set; }
        public int? Anio { get; set; }
        public int? Mes { get; set; }
        public string MesText { get; set; }
        public int? Dia { get; set; }
        public bool Activo { get; set; }
        public decimal Ed_Id { get; set; }
        public string EdNombre { get; set; }
        public decimal SeccId { get; set; }
        public string SecNombre { get; set; }
        public decimal PodId { get; set; }
        public string PodNombre { get; set; }
        public decimal PodOrden { get; set; }
        public decimal GobId { get; set; }
        public string GobClave { get; set;}
        public string GobNombre { get; set; }
        public decimal IndOrden { get; set; }
        public decimal IndParrafo { get; set; }
        public decimal ParrId { get; set; }
        public string ParrTexto { get; set; }
        public decimal ParrPagina { get; set; }
        public decimal ParrOrden { get; set; }
        public string GobClaveLg { get; set; }
    }
}