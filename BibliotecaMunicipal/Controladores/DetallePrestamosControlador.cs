using BibliotecaMunicipal.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Controladores
{
    public class DetallePrestamosControlador
    {
        Conexion Con = new Conexion();

        public void InsertarDetallePretamo(DetallePrestamos detalleprestamo)
        {
            try
            {
                Con.Conectar();
                string sql = "INSERT INTO DetallesPrestamos VALUES(@dtpPrestamo, @dtpLibro, @dtpCantidad, @dtpFechaFin, @dtpFechaVen)";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@dtpPrestamo", detalleprestamo.IdPrestamo);
                cmd.Parameters.AddWithValue("@dtpLibro", detalleprestamo.IdLibro);
                cmd.Parameters.AddWithValue("@dtpCantidad", detalleprestamo.CantLibro);
                cmd.Parameters.AddWithValue("@dtpFechaFin", detalleprestamo.FechaFin);
                cmd.Parameters.AddWithValue("@dtpFechaVen", detalleprestamo.FechaVen);

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    Console.WriteLine("Detalle agregado con exito");
                }
                else
                {
                    Console.WriteLine("El detalle no pudo ser agregado con exito");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }
        }
    }
}