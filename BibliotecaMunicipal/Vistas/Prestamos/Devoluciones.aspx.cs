using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BibliotecaMunicipal.Vistas.Prestamos
{
    public partial class Devoluciones : System.Web.UI.Page
    {
        Controladores.UsuarioControlador Cu = new Controladores.UsuarioControlador();
        Controladores.LibroControlador Cl = new Controladores.LibroControlador();
        Controladores.PrestamosControlador Cp = new Controladores.PrestamosControlador();
        Controladores.SancionesControlador Cs = new Controladores.SancionesControlador();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarUsuarios();
                ListarLibros();
            }
        }
        public void ListarUsuarios()
        {
            ListaUsuarios.DataTextField = "usuNombre";
            ListaUsuarios.DataValueField = "usuDocumento";
            ListaUsuarios.DataSource = Cu.ListaUsuarios("");
            ListaUsuarios.DataBind();
        }
        public void ListarLibros()
        {
            ListaLibros.DataSource = Cl.MostrarLibros("");
            ListaLibros.DataTextField = "libNombre";
            ListaLibros.DataValueField = "libCodigo";
            ListaLibros.DataBind();
        }
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            Modelos.Sancion Ms = new Modelos.Sancion();
            Controladores.DetallePrestamosControlador Cdc = new Controladores.DetallePrestamosControlador();
            string[] vect = new string[2];
            vect = Cs.ConsultaExistencia(ListaLibros.SelectedValue, ListaUsuarios.SelectedValue);
            DateTime fecha = Convert.ToDateTime(Fecha.Text);
            DateTime fechaEn = Convert.ToDateTime(vect[1]);
            if (fecha > fechaEn)
            {
                Cu.ActualizarEstadoUsuario(ListaUsuarios.SelectedValue);
                Ms.SanDiaSancion = "5";
                Ms.SanFechaFin = fecha.AddDays(5).ToString();
                Ms.SanFechaInicio = Fecha.Text;
                Ms.SanPrestamo = vect[0];
                Cs.InsertarSancion(Ms);
            }
        }
    }
}