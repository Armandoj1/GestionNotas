using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;


namespace DAL
{
    public class D_Materias
    {

        static string connectionString = "Data Source=sql.holamundodevs.com;Initial Catalog=Jose_NotasDB;User ID=joserodriguez;Password=Holamundo123*;";
        SqlConnection connection = new SqlConnection(connectionString);

        public void AgregarMateria(string MateriaID, string NombreMateria)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarMaterias", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "AgregarMateria");
                cmd.Parameters.AddWithValue("@MateriaID", MateriaID);
                cmd.Parameters.AddWithValue("@NombreMateria", NombreMateria);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public DataTable MostraMateriaGrado()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "MostrarGradosMaterias");
                SqlDataAdapter tabla = new SqlDataAdapter(cmd);
                DataTable datos = new DataTable();
                tabla.Fill(datos);
                return datos;


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


        public void VincularMateriaGrado(string MateriaID, int GradoID)
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "VincularMateriasGrado");
                cmd.Parameters.AddWithValue("@MateriaID", MateriaID);
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

        public void VincularMateria(string MateriaID, string DocenteID)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarMaterias", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "Docente");
                cmd.Parameters.AddWithValue("@DocenteID", DocenteID);
                cmd.Parameters.AddWithValue("@MateriaID", MateriaID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }




        public DataTable MostrarMateriasCreacion()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarMaterias", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "ListarMaterias");
                DataTable dataTable = new DataTable();
                SqlDataAdapter datos = new SqlDataAdapter(cmd);
                datos.Fill(dataTable);
                return dataTable;

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

        public DataTable MostrarMaterias()
        {

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GestionarMaterias", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Accion", "MostrarMaterias");
                DataTable dataTable = new DataTable();
                SqlDataAdapter datos = new SqlDataAdapter(command);
                datos.Fill(dataTable);

                return dataTable;

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

        public void ModificarMateria(string NombreMateria, string MateriaID)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarMaterias", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "MateriaModificar");
                cmd.Parameters.AddWithValue("@MateriaID", MateriaID);
                cmd.Parameters.AddWithValue("@NombreMateria", NombreMateria);
                cmd.ExecuteNonQuery();

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


        public void EliminarMateria(string MateriaID)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarMaterias", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "EliminarMateria");
                cmd.Parameters.AddWithValue("@MateriaID", MateriaID);
                cmd.ExecuteNonQuery();



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


        public void CambiarAsignacion(string MateriaID, string DocenteID)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarMaterias", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "CambiarAsignacion");
                cmd.Parameters.AddWithValue("@MateriaID", MateriaID);
                cmd.Parameters.AddWithValue("@DocenteID", DocenteID);
                cmd.ExecuteNonQuery();
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
    }
}
