using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMunicipal.Vistas.Usuarios
{
    public partial class Consultar : System.Web.UI.Page
    {
        Controladores.UsuarioControlador Cu = new Controladores.UsuarioControlador();
        protected void Page_Load(object sender, EventArgs e)
        {
            Mostrar("");
            if (!IsPostBack)
            {
                Listar();
            }
        }
        public void Listar()
        {
            ListaUsuarios.DataTextField = "usuNombre";
            ListaUsuarios.DataValueField = "usuDocumento";
            ListaUsuarios.DataSource = Cu.ListaUsuarios("");
            ListaUsuarios.DataBind();
        }
        public void Mostrar(string dato)
        {
            TablaUsuarios.DataSource = Cu.ListaUsuarios(dato);
            TablaUsuarios.DataBind();
        }
        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            Mostrar(ListaUsuarios.SelectedValue);
        }
    }
}