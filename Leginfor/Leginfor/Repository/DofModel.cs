using Leginfor.Models.Index;
using Leginfor.Models.ModelBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Leginfor.Repository
{
    public class DofModel
    {
        private static dofEntities entidad;
        private static LEG_CJM_V_IIEntities entidadCJM;
        private static string sSelected;
        public static List<Dof> getDof(DateTime? fecha)
        {
            DofView lstDof = new DofView();
            if (!string.IsNullOrEmpty(fecha.ToString()))
                 sSelected = ultimoDiaDof();
            DateTime dSelected = Convert.ToDateTime(sSelected);
            string sYear = dSelected.Year.ToString();
            string sMonth = dSelected.Month.ToString();
            string sDay = dSelected.Day.ToString();
            bool vCompleto = true;
            List<Dof> respuesta;
            string sUbicacion = string.Empty;
            string sDependencia = string.Empty;
            int ed_Id = 0;
            using ( entidad =  new dofEntities())
            {

               var res =  entidad.sps_Publicacion(Convert.ToDateTime(sSelected));


                var query = from dofR in res
                            select new Dof { Id = dofR.do_Id, Fecha = dofR.do_Fecha, Anio = dofR.do_Year, Mes = dofR.do_Month,
                                MesText = dofR.do_MonthText, Dia = dofR.do_Day, Activo = dofR.do_Activo, Ed_Id = dofR.ed_Id,
                                EdNombre = dofR.ed_Nombre, SeccId = dofR.secc_Id, SecNombre = dofR.secc_Nombre, PodId = dofR.pod_Id,
                                PodNombre = dofR.pod_Nombre, PodOrden = dofR.pod_Orden, GobId = dofR.gob_Id, GobClave = dofR.gob_Clave,
                                GobNombre = dofR.gob_Nombre, IndOrden = dofR.ind_Orden, IndParrafo = dofR.ind_Parrafo, ParrId = dofR.parr_Id,
                                ParrTexto = dofR.parr_Texto, ParrPagina = dofR.parr_Pagina, ParrOrden = dofR.parr_Orden, GobClaveLg = dofR.gob_clave_LG
                                           };

                respuesta = query.OrderBy(sec => sec.SeccId)
                                 .ThenBy(pod => pod.PodId)
                                 .ToList();
                           
            }

            return respuesta;
        }

        private static string ultimoDiaDof()
        {
            string ultimoDia = string.Empty;
            using (entidad = new dofEntities())
            {
                var res = entidad.sps_Diario_TheLast();
                foreach (var ultimo in res)
                    ultimoDia = ultimo.Value.ToString("dd/MM/yyyy");
            }
            return ultimoDia;
        }
        public static List<Federales> getRefFederales()
        {
            string sFecha = string.Empty;
            string[] elementos;
            string sTitulo = string.Empty;
            string sExtracto = string.Empty;
            Models.Index.Reformas refor = new Models.Index.Reformas();
            List<Federales> refFederales = new List<Federales>();
            using (entidadCJM = new LEG_CJM_V_IIEntities())
            {
                var queryFederales = entidadCJM.sps_RecuperaID_x_Titulo(1, "INDICE ULTIMAS REFORMAS", 1);
                var feder = from fed in queryFederales
                            select new Federal {
                                ind_Id = fed.ind_Id,
                                cont_Id = fed.cont_Id,
                                cont_Up = fed.cont_Up,
                                cont_Orden = fed.cont_Orden,
                                cont_Fecha = fed.cont_Fecha,
                                cont_Clave = fed.cont_Clave,
                                cont_Titulo = fed.cont_Titulo,
                                cont_Titulo_Corto = fed.cont_Titulo_Corto,
                                cont_Titulo_Indice = fed.cont_Titulo_Indice,
                                cont_Texto = fed.cont_Texto,
                                cont_derogado = fed.cont_derogado,
                                cont_Historico = fed.cont_Historico,
                                est_Actualizado = fed.est_Actualizado,
                                est_revisado = fed.est_revisado,
                                cla_Id = fed.cla_Id,
                                cont_Historico_fecha = fed.cont_Historico_fecha,
                                cont_Activo = fed.cont_Activo,
                                Folio_historico = fed.Folio_historico
                                
                            };

                refor.lstReformasFederales = feder.ToList();
            }

            foreach(var reform in refor.lstReformasFederales)
            {
                sFecha = reform.cont_Texto;
                elementos = Regex.Split(sFecha, "<<lblnmfecha>");
                for(int i= 0; i<= elementos.Count() -1; i++)
                {
                    if (i >= 21)
                        break;
                    if (i > 0)
                    {
                        sFecha = elementos[i].Substring(0, elementos[i].IndexOf("<</lblnmfecha>"));
                        sTitulo = elementos[i].Substring(elementos[i].IndexOf("<<lblnmordenamiento>") + 20, elementos[i].IndexOf("<</lblnmordenamiento>") - (elementos[i].IndexOf("<<lblnmordenamiento>") + 20));
                        sExtracto = elementos[i].Substring(elementos[i].IndexOf("<td width='381'  height='31' >"));
                        sExtracto = sExtracto.Substring(0, sExtracto.IndexOf("</td>"));
                        refFederales.Add(new Federales {
                            Fecha = sFecha,
                            Titulo = limpiaTexto(sTitulo),
                            Extracto = limpiaTexto(sExtracto)
                        });
                        
                    }
                }
            }

            return refFederales;
        }

        private static string limpiaTexto(string sCadena)
        {
            sCadena = sCadena.Replace("cha>", "");
            sCadena = sCadena.Replace("<HD>", "");
            sCadena = sCadena.Replace("<HD+>", "");
            sCadena = sCadena.Replace("</font>", "");
            sCadena = sCadena.Replace("</td>", "");
            sCadena = sCadena.Replace("\r", "");
            sCadena = sCadena.Replace("<td width='162'  height='31' >", "");
            sCadena = sCadena.Replace("<U>>", "");
            sCadena = sCadena.Replace("nmfecha>", "");
            sCadena = sCadena.Replace("nmfe", "");
            sCadena = sCadena.Replace("<b/>", "");
            sCadena = sCadena.Replace("</b>", "");
            sCadena = sCadena.Replace("<u/>", "");
            sCadena = sCadena.Replace("<U/>", "");
            sCadena = sCadena.Replace("</U>", "");
            sCadena = sCadena.Replace("<U>", "");
            sCadena = sCadena.Replace("<td width='381'  height='31' >", "");
            sCadena = sCadena.Replace("\r", "");
            sCadena = sCadena.Replace("\n", "");
            sCadena = sCadena.Replace("<b>", "");


            return sCadena;
        }

        public static List<Relevantes> getRelevantes(int id)
        {
            List<Relevantes> lstRelevantes;
            using (var entidadUniverso =  new universoEntities())
            {
                var resRelev = entidadUniverso.sps_Noticia_list(id);
                var query = from rel in resRelev
                            select new Relevantes
                            {
                                Ver = rel.noti_Ver,
                                Id = rel.noti_Id,
                                SeccId = rel.secc_id,
                                SeccNombre = rel.secc_Nombre,
                                NotiPublicacion = rel.noti_Publicacion,
                                Publicacion = rel.noti_Publicada,
                                Titulo = rel.noti_Titulo,
                                Fuente = rel.noti_fuente,
                                Resumen = rel.noti_Resumen,
                                Estado = rel.noti_Estado,
                                Vinculo = rel.Vinculo
                            };
                 lstRelevantes = query.ToList();
            }
            return lstRelevantes;
        }
    }
}