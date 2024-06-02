using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Net.Configuration;

namespace DAL
{
    public class D_Grados
    {
        static string connectionString = "Data Source=sql.holamundodevs.com;Initial Catalog=Jose_NotasDB;User ID=joserodriguez;Password=Holamundo123*;";
        SqlConnection connection = new SqlConnection(connectionString);

        public DataTable ListarGrados()
        {

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GestionarAlumnos", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Accion", "MostrarGrados");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }

            catch (Exception ex)
            {
                throw new Exception("Error al obtener los grados: " + ex.Message);
            }

        }


        public void VincularGrado(string EstudianteID, int GradoID)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "Vincular");
                cmd.Parameters.AddWithValue("@CC", EstudianteID);
                cmd.Parameters.AddWithValue("@GradoID", GradoID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }



        public void Modificar(int GradoID, string EstudianteCC)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "Modificar");
                cmd.Parameters.AddWithValue("@GradoID", GradoID);
                cmd.Parameters.AddWithValue("@CC", EstudianteCC);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error:" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }


        }

        public void CambiarNombreGrado(string NombreGrado, int GradoID)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "CambiarNombreGrado");
                cmd.Parameters.AddWithValue("@NombreGrado", NombreGrado);
                cmd.Parameters.AddWithValue("@GradoID", GradoID);
                cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
        }

       

        public DataTable MostrarModificar()
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "MostrarConGrados");
                SqlDataAdapter tabla = new SqlDataAdapter(cmd);
                DataTable datos = new DataTable();
                tabla.Fill(datos);
                return datos;

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
        }

        public void AgregarGrado(string NombreGrado)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "Agregar");
                cmd.Parameters.AddWithValue("@NombreGrado", NombreGrado);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        

        public DataTable MostrarGrados()
        {

            SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Accion", "MostrarGrados");
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            return dataTable;

        }

        public DataTable MostrarEstudiantes()
        {

            SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Accion", "Mostrar");
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            return dataTable;

        }




    }
}
