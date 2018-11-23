using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Modelos
{
    public class Prestamo
    {
        private string preFecha;
        private string preUsuario;
        public string PreFecha
        {
            get
            {
                return preFecha;
            }
            set
            {
                preFecha = value;
            }
        }
        public string PreUsuario
        {
            get
            {
                return preUsuario;
            }
            set
            {
                preUsuario = value;
            }
        }
    }
}