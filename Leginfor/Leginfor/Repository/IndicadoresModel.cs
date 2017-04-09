using Leginfor.Models.Index;
using Leginfor.Models.ModelBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leginfor.Repository
{
    public class IndicadoresModel
    {
        public static List<Indicadores> getIndicadoresUltimos()
        {
            List<Indicadores> lstIndicadores;
            using (var ind = new indicadoresEntities())
            {
                var indicador = ind.sps_Indicador_Ultimos();
                var query = from indi in indicador
                            select new Indicadores { Indicador = indi.ind_Nombre, Valor = indi.ind_Valor };
                lstIndicadores = query.ToList();
            }

            return lstIndicadores;
        }
    }
}