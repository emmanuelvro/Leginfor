﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Leginfor.Models
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class LeginforModelContainer : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto LeginforModelContainer usando la cadena de conexión encontrada en la sección 'LeginforModelContainer' del archivo de configuración de la aplicación.
        /// </summary>
        public LeginforModelContainer() : base("name=LeginforModelContainer", "LeginforModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto LeginforModelContainer.
        /// </summary>
        public LeginforModelContainer(string connectionString) : base(connectionString, "LeginforModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto LeginforModelContainer.
        /// </summary>
        public LeginforModelContainer(EntityConnection connection) : base(connection, "LeginforModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}
