using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Controladores
{
    public class UsuarioControlador
    {
        Modelos.Conexion Con = new Modelos.Conexion();
        public void InsertarUsuario(Modelos.Usuario us)
        {
            try
            {
                Con.Conectar();
                string sql = "INSERT INTO Usuarios VALUES(@doc, @nom, @dir, @tel, @mail, @est)";
                SqlCommand sc = new SqlCommand(sql, Con.Conex());
                sc.Parameters.AddWithValue("@doc", us.UsuDocumento);
                sc.Parameters.AddWithValue("@nom", us.UsuNombre);
                sc.Parameters.AddWithValue("@dir", us.UsuDireccion);
                sc.Parameters.AddWithValue("@tel", us.UsuTelefono);
                sc.Parameters.AddWithValue("@mail", us.UsuCorreo);
                sc.Parameters.AddWithValue("@est", us.UsuEstado);
                int result = sc.ExecuteNonQuery();
                if(result == 1)
                {
                    Console.WriteLine("Usuario agragado!");
                }
                else
                {
                    Console.WriteLine("El usuario no pudo ser agregado");
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Con.Desconectar();
            }
        }
        public void ActualizarUsuario(Modelos.Usuario us)
        {
            try
            {
                Con.Conectar();
                string sql = "UPDATE Usuarios SET UsuNombre = @nom, UsuDireccion = @dir, UsuTelefono = @tel, UsuCorreo = @mail, UsuEstado = @est WHERE usuDocumento = @doc";
                SqlCommand sc = new SqlCommand(sql, Con.Conex());
                sc.Parameters.AddWithValue("@doc", us.UsuDocumento);
                sc.Parameters.AddWithValue("@nom", us.UsuNombre);
                sc.Parameters.AddWithValue("@dir", us.UsuDireccion);
                sc.Parameters.AddWithValue("@tel", us.UsuTelefono);
                sc.Parameters.AddWithValue("@mail", us.UsuCorreo);
                sc.Parameters.AddWithValue("@est", us.UsuEstado);
                int result = sc.ExecuteNonQuery();
                if (result == 1)
                {
                    Console.WriteLine("Usuario actualizado!");
                }
                else
                {
                    Console.WriteLine("El usuario no pudo ser actualizado");
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
        public void ActualizarEstadoUsuario(string codigo )
        {
            try
            {
                Con.Conectar();
                string sql = "UPDATE Usuarios SET UsuEstado = @est WHERE usuDocumento = @doc";
                SqlCommand sc = new SqlCommand(sql, Con.Conex());
                sc.Parameters.AddWithValue("@doc", codigo);
                sc.Parameters.AddWithValue("@est", "Sancionado");
                int result = sc.ExecuteNonQuery();
                if (result == 1)
                {
                    Console.WriteLine("Usuario sancionado");
                }
                else
                {
                    Console.WriteLine("El usuario no pudo ser sancionado");
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
        public void EliminarUsuario(string dato)
        {
            try
            {
                Con.Conectar();
                string sql = " Delete FROM Usuarios WHERE usuDocumento = @doc ";
                SqlCommand sc = new SqlCommand(sql, Con.Conex());
                sc.Parameters.AddWithValue("@doc", dato);
                int result = sc.ExecuteNonQuery();
                if(result == 1)
                {
                    Console.WriteLine("Usuario Eliminado");
                }else
                {
                    Console.WriteLine("Usuario no fue eliminado");
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Con.Desconectar();
            }
        }
        public string[] BuscarUsuario(string dato)
        {
            string[] datos = new string[5];
            try
            {
                Con.Conectar();
                string sql = "SELECT * FROM Usuarios WHERE usuDocumento = @doc";
                SqlCommand sc = new SqlCommand(sql, Con.Conex());
                sc.Parameters.AddWithValue("@doc", dato);
                SqlDataReader dr = sc.ExecuteReader();
                if (dr.Read())
                {
                    datos[0] = dr.GetString(1);
                    datos[1] = dr.GetString(2);
                    datos[2] = dr.GetString(3);
                    datos[3] = dr.GetString(4);
                    datos[4] = dr.GetString(5);
                }
                else
                {
                    Console.WriteLine("no se encuentra el usuario");
                }
            }
            
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Con.Desconectar();
            }
            return datos;
        }
        public DataTable ListaUsuarios(string dato)
        {
            DataTable DT = new DataTable();
            if (dato == "")
            {
                try
                {
                    Con.Conectar();
                    string sql = "SELECT * FROM Usuarios";
                    SqlDataAdapter cmd = new SqlDataAdapter(sql, Con.Conex());
                    cmd.Fill(DT);
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
            else
            {
                try
                {
                    Con.Conectar();
                    string sql = "SELECT * FROM Usuarios WHERE usuDocumento = @doc";
                    SqlCommand sc = new SqlCommand(sql, Con.Conex());
                    sc.Parameters.AddWithValue("@doc", dato);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = sc;
                    sda.Fill(DT);
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

            return DT;
        }
    }
}