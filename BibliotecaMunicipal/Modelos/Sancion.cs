using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Modelos
{
    public class Sancion
    {
        private string sanPrestamo;
        private string sanDiaSancion;
        private string sanFechaInicio;
        private string sanFechaFin;

        public string SanPrestamo
        {
            get
            {
                return sanPrestamo;
            }
            set
            {
                sanPrestamo = value;
            }
        }
        public string SanDiaSancion
        {
            get
            {
                return sanDiaSancion;
            }
            set
            {
                sanDiaSancion = value;
            }
        }
        public string SanFechaInicio
        {
            get
            {
                return sanFechaInicio;
            }
            set
            {
                sanFechaInicio = value;
            }
        }
        public string SanFechaFin
        {
            get
            {
                return sanFechaFin;
            }
            set
            {
                sanFechaFin = value;
            }
        }

    }
}