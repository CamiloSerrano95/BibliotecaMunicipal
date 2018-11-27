using BibliotecaMunicipal.Controladores;
using BibliotecaMunicipal.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMunicipal.Vistas
{
    public partial class Modificar : System.Web.UI.Page
    {
        AreaControlador AC = new AreaControlador();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarAreas();
            }
        }

        protected void LlenarAreas()
        {
            AreasSelect.DataTextField = "areNombre";
            AreasSelect.DataValueField = "areCodigo";
            AreasSelect.DataSource = AC.MostrarAreas("");
            AreasSelect.DataBind();
            AreasSelect.Items.Insert(0, new ListItem("Seleccione", "0"));
        }

        protected void BuscarArea_Click1(object sender, EventArgs e)
        {
            string[] vector;
            vector = new string[3];

            string codigo = AreasSelect.SelectedItem.Value.ToString();

            vector = AC.BuscarArea(codigo);

            EditarCodigo.Text = vector[0];
            EditarNombre.Text = vector[1];
            EditarTiempo.Text = vector[2];
        }

        protected void ActualizarCambios_Click(object sender, EventArgs e)
        {
            Areas A = new Areas();

            A.CodigoArea = EditarCodigo.Text;
            A.NombreArea = EditarNombre.Text;
            A.TiempoArea = EditarTiempo.Text;

            AC.ActualizarArea(A);

            EditarCodigo.Text = "";
            EditarNombre.Text = "";
            EditarTiempo.Text = "";
        }
    }
}