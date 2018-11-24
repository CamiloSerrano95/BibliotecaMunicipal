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
        Controladores.DetallePrestamosControlador DPC = new Controladores.DetallePrestamosControlador();
        Controladores.UsuarioControlador Cu = new Controladores.UsuarioControlador();
        Controladores.LibroControlador LC = new Controladores.LibroControlador();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listar();
                ListarLibros();
            }

            MostrarDetalles();
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

            IdPrestamo.Text = DPC.CodigoPrestamo();

        }

        protected void ListarLibros()
        {
            ListaLibros.DataTextField = "libNombre";
            ListaLibros.DataValueField = "libCodigo";
            ListaLibros.DataSource = LC.MostrarLibros("");
            ListaLibros.DataBind();
        }

        protected void MostrarDetalles()
        {
            TablaDetallesPrestamo.DataSource = DPC.MostrarPrestamos();
            TablaDetallesPrestamo.DataBind();
        }

        protected void GuardarDetalles_Click(object sender, EventArgs e)
        {
            Modelos.DetallePrestamos DP = new Modelos.DetallePrestamos();

            DP.IdPrestamo = IdPrestamo.Text;
            DP.IdLibro = ListaLibros.SelectedValue.ToString();
            DP.CantLibro = Cantidad.Text;
            DP.FechaFin = FechaEntrega.Text;
            DP.FechaVen = FechaEntrega.Text;

            MostrarDetalles();
        }
    }
}