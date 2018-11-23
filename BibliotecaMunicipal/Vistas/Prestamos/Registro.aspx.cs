using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMunicipal.Vistas.Prestamos
{
    public partial class Registro : System.Web.UI.Page
    {
        Controladores.UsuarioControlador Cu = new Controladores.UsuarioControlador();
        Controladores.PrestamoControlador Cp = new Controladores.PrestamoControlador();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar();
            }
        }
        public void listar()
        {
            ListaUsuarios.DataTextField = "usuNombre";
            ListaUsuarios.DataValueField = "usuDocumento";
            ListaUsuarios.DataSource = Cu.ListaUsuarios("");
            ListaUsuarios.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Modelos.Prestamo pr = new Modelos.Prestamo();
            pr.PreFecha = Fecha.Text;
            pr.PreUsuario = ListaUsuarios.SelectedValue;
            Cp.InsertarPrestamo(pr);
            //comment
        }
    }
}