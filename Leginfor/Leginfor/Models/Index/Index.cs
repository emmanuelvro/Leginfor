using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leginfor.Models.Index
{
    public class Index
    {
        public List<Dof> Dof { get; set; }
        public IEnumerable<Rss> Rss { get; set; }
        public List<Federales> ReformasFed { get; set; }
        public List<Indicadores> lstIndicadores { get; set; }
        public List<Relevantes> lstRelevantesDof { get; set; }
        public List<Relevantes> lstRelGaceta { get; set; }
        public List<Relevantes> lstRelFiscal { get; set; }
    }
}