using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Modelos
{
    public class Libro
    {
        private string codigo;
        private string nombre;
        private string numPag;
        private string autor;
        private string editorial;
        private string area;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string NumPag
        {
            get
            {
                return numPag;
            }

            set
            {
                numPag = value;
            }
        }

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public string Editorial
        {
            get
            {
                return editorial;
            }

            set
            {
                editorial = value;
            }
        }

        public string Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }
    }
}