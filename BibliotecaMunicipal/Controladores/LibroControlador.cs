using BibliotecaMunicipal.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Controladores
{
    public class LibroControlador
    {
        Conexion Con = new Conexion();

        public void InsertarLibro(Libro libro)
        {
            try
            {
                Con.Conectar();
                string sql = "INSERT INTO Libros VALUES(@libCodigo, @libNombre, @libNumPag, @libAutor, @libEditorial, @libArea)";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@libCodigo", libro.Codigo);
                cmd.Parameters.AddWithValue("@libNombre", libro.Nombre);
                cmd.Parameters.AddWithValue("@libNumPag", libro.NumPag);
                cmd.Parameters.AddWithValue("@libAutor", libro.Autor);
                cmd.Parameters.AddWithValue("@libEditorial", libro.Editorial);
                cmd.Parameters.AddWithValue("@libArea", libro.Area);

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    Console.WriteLine("Libro agregado con exito");
                }
                else
                {
                    Console.WriteLine("El libro no pudo ser agregado con exito");
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

        public string[] BuscarLibro(string CodigoLibro)
        {
            string[] data = new string[6];

            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Libros WHERE libCodigo = @libCodigo";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@libCodigo", CodigoLibro);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    data[0] = dr.GetInt32(0).ToString();
                    data[1] = dr.GetString(1);
                    data[2] = dr.GetString(2);
                    data[3] = dr.GetString(3);
                    data[4] = dr.GetString(4);
                    data[5] = dr.GetInt32(5).ToString();
                }
                else
                {
                    Console.WriteLine("No se encuentra el libro");
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
            return data;
        }

        public DataTable MostrarLibros()
        {
            DataTable DT = new DataTable();
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Libros";
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

        public void ActualizarLibro(Libro libro)
        {
            try
            {
                Con.Conectar();
                string sql = "UPDATE Libros SET libNombre = @libNombre, libNumPag = @libNumPag, libAutor = @libAutor, libEditorial = @libEditorial, libArea = @libArea WHERE libCodigo = @libCodigo";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@libNombre", libro.Nombre);
                cmd.Parameters.AddWithValue("@libNumPag", libro.NumPag);
                cmd.Parameters.AddWithValue("@libAutor", libro.Autor);
                cmd.Parameters.AddWithValue("@libEditorial", libro.Editorial);
                cmd.Parameters.AddWithValue("@libArea", libro.Area);
                cmd.Parameters.AddWithValue("@libCodigo", libro.Codigo);

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    Console.WriteLine("Libro actualizado exitosamente");
                }
                else
                {
                    Console.WriteLine("No se pudo actualizar el libro. Intente mas tarde");
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

        public void EliminarLibro(string CodigoLibro)
        {
            try
            {
                Con.Conectar();
                string sql = "DELETE FROM Libros WHERE libCodigo = @libCodigo";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@libCodigo", CodigoLibro);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    Console.WriteLine("Libro eliminada exitosamente");
                }
                else
                {
                    Console.WriteLine("No se pudo eliminar el libro. Intente mas tarde");
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

        public DataTable ConsultarLibro(string Codigo)
        {
            DataTable DT = new DataTable();
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Libros WHERE libCodigo = @libCodigo";
                SqlCommand cmd = new SqlCommand(sql, Con.Conex());
                cmd.Parameters.AddWithValue("@libCodigo", Codigo);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(DT);
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