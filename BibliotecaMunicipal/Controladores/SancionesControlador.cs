using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace BibliotecaMunicipal.Controladores
{
    public class SancionesControlador
    {
        Modelos.Conexion Con = new Modelos.Conexion();
        public void InsertarSancion(Modelos.Sancion Ms)
        {
            try
            {
                Con.Conectar();
                string sql = "INSERT INTO Sanciones VALUES( @sPres, @sDiS, @sFeI, @sFeF)";
                SqlCommand sc = new SqlCommand(sql, Con.Conex());
                sc.Parameters.AddWithValue("@sPres", Ms.SanPrestamo);
                sc.Parameters.AddWithValue("@sDiS", Ms.SanDiaSancion);
                sc.Parameters.AddWithValue("@sFeI", Ms.SanFechaInicio);
                sc.Parameters.AddWithValue("@sFeF", Ms.SanFechaFin);
                int result = sc.ExecuteNonQuery();
                if (result == 1)
                {
                    Console.WriteLine("Sancion insertada");
                    MessageBox.Show("Sancion insertada");
                }
                else
                {
                    Console.WriteLine("La sancion no pudo ser insertada");
                    MessageBox.Show("La sancion no pudo ser insertada");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
            }
            finally
            {
                Con.Desconectar();
            }
        }
        public string[] ConsultaExistencia(string libro, string usuario)
        {
            string[] value = new string[2] ;
            try
            {
                Con.Conectar();
                string sql = "Select preCodigo, dtpFechaVen From DetallesPrestamos, Prestamos,Libros Where DetallesPrestamos.dtpPrestamo = Prestamos.preCodigo AND Libros.libCodigo = @lib AND Prestamos.preUsuario = @us";
                SqlCommand sc = new SqlCommand(sql, Con.Conex());
                sc.Parameters.AddWithValue("@lib", libro);
                sc.Parameters.AddWithValue("@us", usuario);
                SqlDataReader dr = sc.ExecuteReader();
                if (dr.Read())
                {
                    value[0] = dr.GetInt32(0).ToString();
                    value[1] = dr.GetDateTime(1).ToString();
                }
                else
                {
                    Console.WriteLine("False");
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
            return value;
        }

    }
}