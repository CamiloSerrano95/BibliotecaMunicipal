using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Modelos
{
    public class Conexion
    {
        SqlConnection Con = new SqlConnection("Data Source = .; Initial Catalog = BibliotecaMunicipal ; Integrated Security = true");

        public void Conectar()
        {
            try
            {
                Con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Desconectar()
        {
            Con.Close();
        }
        public SqlCommand Create()
        {
            return Con.CreateCommand();
        }

        public SqlConnection Conex()
        {
            return Con;
        }
    }
}