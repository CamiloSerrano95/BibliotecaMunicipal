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
using System.Windows.Forms;

namespace BibliotecaMunicipal.Vistas
{
	public partial class Eliminar : System.Web.UI.Page
	{
        AreaControlador AC = new AreaControlador();
        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                LlenarAreas();
            }
		}

        protected void EliminarArea_Click(object sender, EventArgs e)
        {
            string Codigo = AreasSelect.SelectedValue;

            //AC.EliminarArea(Codigo);

            MessageBox.Show(Codigo);
        }

        protected void LlenarAreas()
        {
            AreasSelect.DataSource = AC.MostrarAreas();
            AreasSelect.DataTextField = "areNombre";
            AreasSelect.DataValueField = "areCodigo";
            AreasSelect.DataBind();
            //AreasSelect.Items.Insert(0, new ListItem("Seleccione", "0"));
        }
    }
}