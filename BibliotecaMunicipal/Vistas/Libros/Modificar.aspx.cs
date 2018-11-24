using BibliotecaMunicipal.Controladores;
using BibliotecaMunicipal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMunicipal.Vistas.Libros
{
    public partial class Modificar : System.Web.UI.Page
    {
        AreaControlador AC = new AreaControlador();
        LibroControlador LC = new LibroControlador();
        Libro L = new Libro();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarAreas();
                LlenarLibros();
            }
        }

        protected void BuscarLibro_Click(object sender, EventArgs e)
        {
            string[] vector;
            vector = new string[6];

            string codigo = LibrosSelect.SelectedItem.Value.ToString();

            vector = LC.BuscarLibro(codigo);

            CodigoLibro.Text = vector[0];
            NombreLibro.Text = vector[1];
            NumPagLibro.Text = vector[2];
            AutorLibro.Text = vector[3];
            EditorialLibro.Text= vector[4];
        }

        protected void ActualizarLibro_Click(object sender, EventArgs e)
        {
            L.Codigo = CodigoLibro.Text;
            L.Nombre = NombreLibro.Text;
            L.NumPag = NumPagLibro.Text;
            L.Autor = AutorLibro.Text;
            L.Editorial = EditorialLibro.Text;
            L.Area = AreasSelect.SelectedItem.Value.ToString();

            LC.ActualizarLibro(L);

            CodigoLibro.Text = "";
            NombreLibro.Text = "";
            NumPagLibro.Text = "";
            AutorLibro.Text = "";
            EditorialLibro.Text = "";
        }

        protected void LlenarLibros()
        {
            LibrosSelect.DataTextField = "libNombre";
            LibrosSelect.DataValueField = "libCodigo";
            LibrosSelect.DataSource = LC.MostrarLibros("");
            LibrosSelect.DataBind();
        }

        protected void LlenarAreas()
        {
            AreasSelect.DataTextField = "areNombre";
            AreasSelect.DataValueField = "areCodigo";
            AreasSelect.DataSource = AC.MostrarAreas("");
            AreasSelect.DataBind();
        }
    }
}