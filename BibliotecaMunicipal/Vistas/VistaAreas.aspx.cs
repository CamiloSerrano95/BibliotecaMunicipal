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
    public partial class VistaAreas : System.Web.UI.Page
    {
        Conexion Con = new Conexion();
        AreaControlador AC = new AreaControlador();
        Areas A = new Areas();
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarAreas();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                        
            A.CodigoArea = CodigoArea.Text;
            A.NombreArea = NombreArea.Text;
            A.TiempoArea = TiempoArea.Text;

            AC.InsertarArea(A);

            CodigoArea.Text = "";
            NombreArea.Text = "";
            TiempoArea.Text = "";

            MostrarAreas();
        }

        protected void MostrarAreas()
        {
            Con.Conectar();
            string sql = "SELECT * FROM Areas";
            SqlDataAdapter cmd = new SqlDataAdapter(sql, Con.Conex());
            DataTable DT = new DataTable();
            cmd.Fill(DT);
            this.TableAllAreas.DataSource = DT;
            TableAllAreas.DataBind();
        }
    }
}