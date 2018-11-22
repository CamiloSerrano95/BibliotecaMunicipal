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
    public partial class Consultar : System.Web.UI.Page
    {
        AreaControlador AC = new AreaControlador();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarAreas();
            }
        }

        protected void ConsultarArea_Click(object sender, EventArgs e)
        {
            string codigo = AreasSelect.SelectedItem.Value.ToString();

            TableConsultaArea.DataSource = AC.ConsultarArea(codigo);
            TableConsultaArea.DataBind();
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