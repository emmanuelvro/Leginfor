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
    
    public partial class cnsIndicador
    {
        public int ind_Id { get; set; }
        public string ind_Nombre { get; set; }
        public string ind_Corto { get; set; }
        public string ind_Largo { get; set; }
        public string ind_Dato1 { get; set; }
        public string ind_Dato2 { get; set; }
        public string ind_Dato3 { get; set; }
        public string ind_Dato4 { get; set; }
        public bool ind_Importe { get; set; }
        public bool ind_Porcentaje { get; set; }
        public int ind_Decimales { get; set; }
        public bool ind_Scroll { get; set; }
        public decimal ind_Valor { get; set; }
        public bool ind_Activo { get; set; }
        public int tab_Id { get; set; }
        public string tab_Nombre { get; set; }
        public decimal val_Id { get; set; }
        public System.DateTime val_Fecha { get; set; }
        public Nullable<int> val_Day { get; set; }
        public Nullable<int> val_Month { get; set; }
        public string val_MonthText { get; set; }
        public Nullable<int> val_Year { get; set; }
        public double val_Dato1 { get; set; }
        public double val_Dato2 { get; set; }
        public double val_Dato3 { get; set; }
        public double val_Dato4 { get; set; }
        public double val_Dato5 { get; set; }
        public double val_Dato6 { get; set; }
        public int apli_Id { get; set; }
        public int val_Aplicar { get; set; }
        public string val_MesTexto { get; set; }
        public string val_MesCorto { get; set; }
        public string per_Year { get; set; }
        public string formato { get; set; }
    }
}