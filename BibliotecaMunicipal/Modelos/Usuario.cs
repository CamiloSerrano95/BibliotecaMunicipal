using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Modelos
{
    public class Usuario
    {
        private string usuDocumento;
        private string usuNombre;
        private string usuDireccion;
        private string usuTelefono;
        private string usuCorreo;
        private string usuEstado;

        public string UsuDocumento
        {
            get
            {
                return usuDocumento;
            }
            set
            {
                usuDocumento = value;
            }
        }
        public string UsuNombre
        {
            get
            {
                return usuNombre;
            }
            set
            {
                usuNombre = value;
            }
        }
        public string UsuDireccion
        {
            get
            {
                return usuDireccion;
            }
            set
            {
                usuDireccion = value;
            }
        }
        public string UsuTelefono
        {
            get
            {
                return usuTelefono;
            }

            set
            {
                usuTelefono = value;
            }
        }
        public string UsuCorreo
        {
            get
            {
                return usuCorreo;
            }
            set
            {
                usuCorreo = value;
            }
        }
        public string UsuEstado
        {
            get
            {
                return usuEstado;
            }
            set
            {
                usuEstado = value;
            }
        }
    }
}