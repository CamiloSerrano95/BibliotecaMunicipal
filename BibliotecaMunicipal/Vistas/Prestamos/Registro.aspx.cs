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
        protected void Page_Load(object sender, EventArgs e)
        {
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
        protected void BtnGuardarPrestamo_Click(object sender, EventArgs e)
        {
            Controladores.PrestamosControlador Cp = new Controladores.PrestamosControlador();
            Modelos.Prestamo Mp = new Modelos.Prestamo();
            Mp.PreFecha = Fecha.Text;
            Mp.PreUsuario = ListaUsuarios.Text;
            Cp.InsrtarPrestamo(Mp);
        }
    }
}