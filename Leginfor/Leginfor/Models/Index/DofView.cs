using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leginfor.Models.Index
{
    public class DofView
    {
       public List<Dof> lstEjecutivo { get; set; }
       public List<Dof> lstLegislativo { get; set; }
       public List<Dof> lstJudicial { get; set; }
    }
}