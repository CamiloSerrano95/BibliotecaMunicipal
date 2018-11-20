using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Modelos
{
    public class DetallePrestamos
    {
        private string idPrestamo;
        private string idLibro;
        private string cantLibro;
        private string fechaFin;
        private string fechaVen;

        public string IdPrestamo
        {
            get
            {
                return idPrestamo;
            }

            set
            {
                idPrestamo = value;
            }
        }

        public string IdLibro
        {
            get
            {
                return idLibro;
            }

            set
            {
                idLibro = value;
            }
        }

        public string CantLibro
        {
            get
            {
                return cantLibro;
            }

            set
            {
                cantLibro = value;
            }
        }

        public string FechaFin
        {
            get
            {
                return fechaFin;
            }

            set
            {
                fechaFin = value;
            }
        }

        public string FechaVen
        {
            get
            {
                return fechaVen;
            }

            set
            {
                fechaVen = value;
            }
        }
    }
}