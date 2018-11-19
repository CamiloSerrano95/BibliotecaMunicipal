using BibliotecaMunicipal.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Controladores
{
    public class AreaControlador
    {
        Conexion Con = new Conexion();

        public void InsertarArea(Areas area)
        {
            try
            {
                Con.Conectar();
                string sql = "INSERT INTO Areas VALUES(@areCodigo, @areNombre, @areTiempo)";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@areCodigo", area.CodigoArea);
                cmd.Parameters.AddWithValue("@areNombre", area.NombreArea);
                cmd.Parameters.AddWithValue("@areTiempo", area.TiempoArea);

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    Console.WriteLine("Cliente agregado con exito");
                }
                else
                {
                    Console.WriteLine("El cliente no pudo ser agregado con exito");
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }
        }

        public string[] BuscarArea(string CodigoArea)
        {
            string[] data = new string[3];

            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Areas WHERE areCodigo = @areaCodigo";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@areaCodigo", CodigoArea);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    data[0] = dr.GetInt32(0).ToString();
                    data[1] = dr.GetString(1);
                    data[2] = dr.GetString(2);
                } else
                {
                    Console.WriteLine("No se encuentra el area");
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }
            return data;
        }

        public void MostrarAreas()
        {
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Areas";
                SqlDataAdapter cmd = new SqlDataAdapter(sql, Con.Conex());
                DataTable DT = new DataTable();
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
        }

        public void ActualizarArea(Areas area)
        {
            try
            {
                Con.Conectar();
                string sql = "UPDATE Areas SET areNombre = @areNombre, areTiempo = @areTiempo WHERE areCodigo = @areCodigo";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@areNombre", area.NombreArea);
                cmd.Parameters.AddWithValue("@areTiempo", area.TiempoArea);
                cmd.Parameters.AddWithValue("@areCodigo", area.CodigoArea);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    Console.WriteLine("Area actualizada exitosamente");
                }
                else
                {
                    Console.WriteLine("No se pudo actualizar el area. Intente mas tarde");
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Con.Desconectar();
            }
        }

        public void EliminarArea(string CodigoArea)
        {
            try
            {
                Con.Conectar();
                string sql = "DELETE FROM Areas WHERE areCodigo = @areCodigo";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@areCodigo", CodigoArea);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    Console.WriteLine("Area eliminada exitosamente");
                }
                else
                {
                    Console.WriteLine("No se pudo eliminar el area. Intente mas tarde");
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