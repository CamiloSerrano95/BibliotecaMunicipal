using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Controladores
{
    public class PrestamoControlador
    {
        Modelos.Conexion Con = new Modelos.Conexion();
        public void InsertarPrestamo(Modelos.Prestamo pr)
        {
            try
            {
                Con.Conectar();
                string sql = "INSERT INTO Prestamos VALUES(@prFec, @prUs)";
                SqlCommand sc = new SqlCommand(sql, Con.Conex());
                sc.Parameters.AddWithValue("@prFec", pr.PreFecha);
                sc.Parameters.AddWithValue("@prUs", pr.PreUsuario);
                int result = sc.ExecuteNonQuery();
                if (result == 1)
                {
                    Console.WriteLine("Prestamo registrado");
                }
                else
                {
                    Console.WriteLine("El prestamo no fue registrado");
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Con.Desconectar();
            }

        }
    }
}