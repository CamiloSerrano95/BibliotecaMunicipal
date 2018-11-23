using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMunicipal.Vistas.Usuarios
{
    public partial class Insertar : System.Web.UI.Page
    {
        Controladores.UsuarioControlador Cu = new Controladores.UsuarioControlador();
        protected void Page_Load(object sender, EventArgs e)
        {
            Mostrartabla("");
        }
        public void Mostrartabla(string dato)
        {
            TablaUsuarios.DataSource = Cu.ListaUsuarios(dato);
            TablaUsuarios.DataBind();
        }
        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            
            Modelos.Usuario us = new Modelos.Usuario();
            us.UsuDocumento = Documento.Text;
            us.UsuNombre = Nombre.Text;
            us.UsuDireccion = Direccion.Text;
            us.UsuTelefono = Telefono.Text;
            us.UsuCorreo = Correo.Text;
            us.UsuEstado = Estado.Text;
            Cu.InsertarUsuario(us);
            Documento.Text = "";
            Nombre.Text = "";
            Direccion.Text = "";
            Telefono.Text = "";
            Correo.Text = "";
            Estado.Text = "";
            Mostrartabla("");
            Documento.Focus();
        }
    }
}