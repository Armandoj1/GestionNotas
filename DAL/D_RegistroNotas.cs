using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_RegistroNotas
    {


        public DataTable MostrarNotas(int GradoID)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarNotas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "Mostrar");
                    cmd.Parameters.AddWithValue("@GradoID", GradoID);
                    SqlDataAdapter datos = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException(ex.Message);
                }
            }

        }

        public DataTable MostrarPeriodo()
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarNotas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "MostrarPeriodos");
                    SqlDataAdapter datos = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException ("Error: " + ex.Message);
                }



            }
        }

        public DataTable FiltrarRegistroNotas(string MateriaID, int GradoID, int Periodo)
        {
            using(SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarNotas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "FiltroRegistro");
                    cmd.Parameters.AddWithValue("@MateriaID", MateriaID);
                    cmd.Parameters.AddWithValue("@GradoID", GradoID);
                    cmd.Parameters.AddWithValue("@PeriodoSeleccionado", Periodo);
                    SqlDataAdapter datos = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
            }
        }




        public void RegistrarNotas(string EstudianteCC, string MateriaID, int Periodo, decimal nota, string Observacion)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarNotas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "RegistrarNota");
                    cmd.Parameters.AddWithValue("@EstudianteCC", EstudianteCC);
                    cmd.Parameters.AddWithValue("@MateriaID", MateriaID);
                    cmd.Parameters.AddWithValue("@PeriodoID", Periodo);
                    cmd.Parameters.AddWithValue("@Nota", nota);
                    cmd.Parameters.AddWithValue("@Observacion", Observacion);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }



            }
        }

        public void ModificarNota(string EstudianteCC, string MateriaID, int Periodo, decimal nota, string Observacion)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarNotas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "ModificarNota");
                    cmd.Parameters.AddWithValue("@EstudianteCC", EstudianteCC);
                    cmd.Parameters.AddWithValue("@MateriaID", MateriaID);
                    cmd.Parameters.AddWithValue("@PeriodoID", Periodo);
                    cmd.Parameters.AddWithValue("@Nota", nota);
                    cmd.Parameters.AddWithValue("@Observacion", Observacion);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error: " + ex.Message);
                }


            }
        }
    }
}
