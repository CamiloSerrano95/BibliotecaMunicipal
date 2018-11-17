using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Modelos
{
    public class Areas
    {
        private string codigoarea;
        private string nombrearea;
        private string tiempoarea;

        public string CodigoArea
        {
            get
            {
                return codigoarea;
            }

            set
            {
                codigoarea = value;
            }
        }

        public string NombreArea
        {
            get
            {
                return nombrearea;
            }

            set
            {
                nombrearea = value;
            }
        }

        public string TiempoArea
        {
            get
            {
                return tiempoarea;
            }

            set
            {
                tiempoarea = value;
            }
        }
    }
}