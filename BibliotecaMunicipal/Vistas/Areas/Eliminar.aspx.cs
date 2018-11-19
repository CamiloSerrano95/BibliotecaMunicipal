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
	public partial class Eliminar : System.Web.UI.Page
	{
        AreaControlador AC = new AreaControlador();
        protected void Page_Load(object sender, EventArgs e)
		{
            LlenarAreas();
		}

        protected void EliminarArea_Click(object sender, EventArgs e)
        {
            string Codigo = AreasSelect.SelectedItem.Value.ToString();

            AC.EliminarArea(Codigo);
        }

        protected void LlenarAreas()
        {
            Conexion Con = new Conexion();
            Con.Conectar();
            string sql = "SELECT * FROM Areas";
            SqlDataAdapter cmd = new SqlDataAdapter(sql, Con.Conex());
            DataTable DT = new DataTable();
            cmd.Fill(DT);

            AreasSelect.DataTextField = "areNombre";
            AreasSelect.DataValueField = "areCodigo";
            AreasSelect.DataSource= DT;
            AreasSelect.DataBind();
        }
    }
}