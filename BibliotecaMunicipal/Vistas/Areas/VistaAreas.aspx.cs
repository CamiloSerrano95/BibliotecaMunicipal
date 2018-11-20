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
        //Conexion Con = new Conexion();
        AreaControlador AC = new AreaControlador();
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarAreas();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Areas A = new Areas();
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
            TableAllAreas.DataSource = AC.MostrarAreas();
            TableAllAreas.DataBind();
        }
    }
}