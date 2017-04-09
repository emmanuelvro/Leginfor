using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leginfor.Models
{
    public class Usuario
    {
        private string _nombre;
        private string _apPaterno;
        private string _apMaterno;

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string ApPaterno
        {
            get
            {
                return _apPaterno;
            }

            set
            {
                _apPaterno = value;
            }
        }

        public string ApMaterno
        {
            get
            {
                return _apMaterno;
            }

            set
            {
                _apMaterno = value;
            }
        }
    }
}