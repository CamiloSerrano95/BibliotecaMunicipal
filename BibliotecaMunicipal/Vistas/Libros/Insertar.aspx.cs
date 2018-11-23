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
    public partial class Insertar : System.Web.UI.Page
    {
        LibroControlador LC = new LibroControlador();
        AreaControlador AC = new AreaControlador();
        Libro L = new Libro();
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarLibros();
            if (!IsPostBack)
            {
                LlenarAreas();
            }
        }

        protected void InsertarLibro_Click(object sender, EventArgs e)
        {

            L.Codigo = CodigoLibro.Text;
            L.Nombre = NombreLibro.Text;
            L.NumPag = NumPagLibro.Text;
            L.Autor = AutorLibro.Text;
            L.Editorial = EditorialLibro.Text;
            L.Area = AreasSelect.SelectedValue;

            LC.InsertarLibro(L);

            MostrarLibros();

            CodigoLibro.Text = "";
            NombreLibro.Text = ""; 
            NumPagLibro.Text = ""; 
            AutorLibro.Text = "";
            EditorialLibro.Text = "";
        }

        protected void MostrarLibros()
        {
            TablaLibros.DataSource = LC.MostrarLibros();
            TablaLibros.DataBind();
        }

        protected void LlenarAreas()
        {
            AreasSelect.DataSource = AC.MostrarAreas();
            AreasSelect.DataTextField = "areNombre";
            AreasSelect.DataValueField = "areCodigo";
            AreasSelect.DataBind();
            AreasSelect.Items.Insert(0, new ListItem("Seleccione", "0"));
        }
    }
}