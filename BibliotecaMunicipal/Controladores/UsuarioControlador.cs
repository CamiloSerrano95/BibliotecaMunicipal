using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BibliotecaMunicipal.Controladores
{
    public class UsuariosControlador
    {
        Modelos.Conexion Con = new Modelos.Conexion();
        public void InsertarUsuario(Modelos.Usuario us)
        {
            try
            {
                Con.Conectar();
                string sql = "INSERT INTO Usuarios VALUES(@doc,@nom,@dir,@tel,@mail,@est) ";
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
                    Console.WriteLine("Usuario agregado con exito!");
                }
                else
                {
                    Console.WriteLine("El Usuario no pudo ser ingresado!");
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
        public void ActualizarUsuario(Modelos.Usuario us)
        {
            try
            {
                Con.Conectar();
                string sql = "UPDATE Usuarios Set UsuNombre =  @nom, UsuDireccion = @dir, UsuTelefono = @tel, UsuCorreo = @mail, UsuEstado = @est WHERE UsuDocumento = @doc";
                SqlCommand sc = new SqlCommand(sql, Con.Conex());
                sc.Parameters.AddWithValue("@doc", us.UsuDocumento);
                sc.Parameters.AddWithValue("@nom", us.UsuNombre);
                sc.Parameters.AddWithValue("@dir", us.UsuDireccion);
                sc.Parameters.AddWithValue("@tel", us.UsuTelefono);
                sc.Parameters.AddWithValue("@mail", us.UsuCorreo);
                sc.Parameters.AddWithValue("@est", us.UsuEstado);
                sc.ExecuteNonQuery();
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
        public void BuscarUsuario(string dato)
        {
            try{
                Con.Conectar();
                string sql="Select * FROM Usuarios WHERE UsuDocumento=@doc";
                SqlCommand sc = new SqlCommand(sql, Con.Conex());
                sc.Parameters.AddWithValue("@doc", dato);
                sc.ExecuteNonQuery();

            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
            finally{
                Con.Desconectar();
            }
        }
        public void EliminarUsuario(string dato)
        {
            try
            {
                Con.Conectar();
                string sql = "DELETE FROM Usuarios WHERE UsuDocumento = @doc";
                SqlCommand sc = new SqlCommand(sql, Con.Conex());
                sc.Parameters.AddWithValue("@doc", dato);
                sc.ExecuteNonQuery();
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
