using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_Boletines
    {

        public DataTable MostrarBoletines()
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarNotas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "MostrarNotas");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
            }

        }

        public DataTable MostrarBoletinesGrados(int Grado)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarNotas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "MostrarNotasGrados");
                    cmd.Parameters.AddWithValue("@GradoID", Grado);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
            }

        }



        public DataTable MostrarBoletinesGradosManual(string Grado)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarNotas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "MostrarNotasGrados");
                    cmd.Parameters.AddWithValue("@NombreGrado", Grado);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
            }
        }

        public DataTable MostrarBoletinesCedula(string Cedula)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarNotas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "BoletinEstudiante");
                    cmd.Parameters.AddWithValue("@EstudianteCC", Cedula);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
            }
        }

        public DataTable MostrarBoletinesMateria(string MateriaID)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarNotas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "MostrarNotasMateria");
                    cmd.Parameters.AddWithValue("@MateriaID", MateriaID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
            }
        }


        public DataTable MostrarBoletinesMateriaManual(string NombreMateria)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarNotas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "MostrarNotasMateria");
                    cmd.Parameters.AddWithValue("@NombreMateria", NombreMateria);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: " + ex.Message);
                }
            }
        }





    }
}
