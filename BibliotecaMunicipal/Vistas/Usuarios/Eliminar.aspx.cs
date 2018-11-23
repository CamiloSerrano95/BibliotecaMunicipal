using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMunicipal.Vistas.Usuarios
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                listar();
            }
        }
        public void listar()
        {
            Controladores.UsuarioControlador us = new Controladores.UsuarioControlador();
            ListaUsuarios.DataTextField = "usuNombre";
            ListaUsuarios.DataValueField = "usuDocumento";
            ListaUsuarios.DataSource = us.ListaUsuarios("");
            ListaUsuarios.DataBind();
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Controladores.UsuarioControlador Cu = new Controladores.UsuarioControlador();
            Cu.EliminarUsuario(ListaUsuarios.SelectedValue);
            listar();
        }
    }
}