using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_GestionDocentes
    {
        static string connectionString = "Data Source=sql.holamundodevs.com;Initial Catalog=Jose_NotasDB;User ID=joserodriguez;Password=Holamundo123*;";
        SqlConnection connection = new SqlConnection(connectionString);


        public void AgregarDocente(string Nombre, string CC, DateTime FechaNacimiento, string Direccion, int Especialidad, string Telefono)
        {
            try
            {           

                 //Si algún error revisar el orden en que se mandan 
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "AgregarDocente");
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@CC", CC);
                cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@EspecialidadID", Especialidad);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);


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

        public void ModificarDocente(String CC, string Nombre, DateTime FechaNacimiento, string Direccion, int Especialidad, string Telefono)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "ModificarDocente");
                cmd.Parameters.AddWithValue("@CC", CC);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@EspecialidadID", Especialidad);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);


                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new ApplicationException ("Error: "+ ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();

                }
            }
        }


        public DataTable MostrarDocentes()
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "MostrarDocentes");

                SqlDataAdapter datos = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;

            }
            catch (Exception ex)
            {

                throw new ApplicationException ("Error: "+ ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }   

        }

        public DataTable MostrarDocentesCedula(string CC)
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "MostrarDocentesCedula");
                cmd.Parameters.AddWithValue("@CC", CC);
                SqlDataAdapter datos = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public DataTable MostrarDocentesEspecialidad(string Especialidad)
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "MostrarDocentesEspecialidad");
                cmd.Parameters.AddWithValue("@EspecialidadID", Especialidad);
                SqlDataAdapter datos = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public void EliminarDocente(string CC)
        {
            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("GestionarDocentes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "EliminarDocente");
                    cmd.Parameters.AddWithValue("@CC", CC);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al intentar eliminar los datos del docente: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        public DataTable MostrarEspecialidad()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarDocentes", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "MostrarEspecialidad");
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception ex )
            {

                throw new ApplicationException ("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


    }
}
