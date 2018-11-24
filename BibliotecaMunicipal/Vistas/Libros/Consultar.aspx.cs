using BibliotecaMunicipal.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMunicipal.Vistas.Libros
{
    public partial class Consultar : System.Web.UI.Page
    {
        LibroControlador LC = new LibroControlador();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarLibros();
            }
        }

        protected void ConsultarLibro_Click(object sender, EventArgs e)
        {
            string codigo = LibrosSelect.SelectedItem.Value.ToString();

            TablaConsultaLibro.DataSource = LC.MostrarLibros(codigo);
            TablaConsultaLibro.DataBind();
        }

        protected void LlenarLibros()
        {
            LibrosSelect.DataSource = LC.MostrarLibros("");
            LibrosSelect.DataTextField = "libNombre";
            LibrosSelect.DataValueField = "libCodigo";
            LibrosSelect.DataBind();
            LibrosSelect.Items.Insert(0, new ListItem("Seleccione", "0"));
        }
    }
}