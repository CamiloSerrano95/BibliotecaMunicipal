using System;
using System.Collections.Generic;
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
                sc.Parameters.AddWithValue("@est", us.UsuTelefono);
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
    }
}