using BibliotecaMunicipal.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

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

        public string CodigoPrestamo()
        {
            string Codigo = "";
            try
            {
                Con.Conectar();
                string sql = "SELECT MAX(preCodigo) FROM Prestamos";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Codigo = dr.GetInt32(0).ToString();
                }
                else
                {
                    Console.WriteLine("No se encuentra el prestamo");
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

            return Codigo;
        }

        public void ActualizarDetalle(string fecha, string codigo)
        {
            try
            {
                Con.Conectar();
                string sql = "UPDATE DetallePrestamos SET dtpfechadev = @fec WHERE dtpPrestamo = @preC";
                SqlCommand sc = new SqlCommand(sql, Con.Conex());
                sc.Parameters.AddWithValue("@preC", codigo);
                sc.Parameters.AddWithValue("@fec", fecha);
                int result = sc.ExecuteNonQuery();
                if (result == 1)
                {
                    Console.WriteLine("Actualizado ");
                    MessageBox.Show("Actualizado");
                }
                else
                {
                    Console.WriteLine("No pudo ser actualizado");
                    MessageBox.Show("No actualizado");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Con.Desconectar();
            }
        }

        public DataTable MostrarPrestamos()
        {
            DataTable DT = new DataTable();
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM DetallesPrestamos";
                SqlDataAdapter cmd = new SqlDataAdapter(sql, Con.Conex());
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }

            return DT;
        }
    }
}