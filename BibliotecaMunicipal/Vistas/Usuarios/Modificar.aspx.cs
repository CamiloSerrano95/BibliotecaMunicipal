using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMunicipal.Vistas.Usuarios
{
    public partial class Modificar : System.Web.UI.Page
    {
        Controladores.UsuarioControlador Cu = new Controladores.UsuarioControlador();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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
        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            string[] vect = new string[5];
            vect = Cu.BuscarUsuario(ListaUsuarios.SelectedValue);
            NombreBusqueda.Text = vect[0];
            DireccionBusqueda.Text = vect[1];
            TelefonoBusqueda.Text = vect[2];
            CorreoBusqueda.Text = vect[3];
            EstadoBusqueda.Text = vect[4];
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            Modelos.Usuario us = new Modelos.Usuario();
            us.UsuDocumento = ListaUsuarios.SelectedValue;
            us.UsuNombre = NombreBusqueda.Text;
            us.UsuDireccion = DireccionBusqueda.Text;
            us.UsuCorreo = CorreoBusqueda.Text;
            us.UsuTelefono = TelefonoBusqueda.Text;
            us.UsuEstado = EstadoBusqueda.Text;
            Cu.ActualizarUsuario(us);
            NombreBusqueda.Text = "";
            DireccionBusqueda.Text = "";
            CorreoBusqueda.Text = "";
            TelefonoBusqueda.Text = "";
            EstadoBusqueda.Text = "";
            listar();
        }
    }
}