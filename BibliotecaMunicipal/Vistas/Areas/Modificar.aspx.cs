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
            LlenarAreas();
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
            AreasSelect.DataSource = DT;
            AreasSelect.DataBind();
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
    }
}