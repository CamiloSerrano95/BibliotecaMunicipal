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
        Conexion Con = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarAreas();
        }

        protected void ConsultarArea_Click(object sender, EventArgs e)
        {
            string codigo = AreasSelect.SelectedItem.Value.ToString();
            
            Con.Conectar();

            string sql = "SELECT * FROM Areas WHERE areCodigo LIKE '%'+@areaCodigo+'%'";
            SqlCommand cmd = new SqlCommand(sql, Con.Conex());
            cmd.Parameters.AddWithValue("@areaCodigo", codigo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            sda.Fill(DT);

            TableConsultaArea.DataSource = DT;
            TableConsultaArea.DataBind();
        }

        protected void LlenarAreas()
        {
            Con.Conectar();
            string sql = "SELECT * FROM Areas";
            SqlDataAdapter cmd = new SqlDataAdapter(sql, Con.Conex());
            DataTable DT = new DataTable();
            cmd.Fill(DT);

            AreasSelect.DataTextField = "areNombre";
            AreasSelect.DataValueField = "areCodigo";
            AreasSelect.DataSource = DT;
            AreasSelect.DataBind();
        }
    }
}