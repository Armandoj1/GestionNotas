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

        public void AgregarMateria(string MateriaID, string NombreMateria)
        {
            using (SqlConnection connection = Conexion.GetConnection())
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
        }

        public DataTable MostraMateriaGrado()
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "GradosMaterias");
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
        }

        public void VincularMateriaGrado(string MateriaID, int GradoID)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {

                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "VincularGrados");
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
        }

        public void VincularMateria(string MateriaID, string DocenteID, int GradoID)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarMaterias", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "Docente");
                    cmd.Parameters.AddWithValue("@DocenteID", DocenteID);
                    cmd.Parameters.AddWithValue("@MateriaID", MateriaID);
                    cmd.Parameters.AddWithValue("@GradoID", GradoID);
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
        }



        public DataTable MostrarMateriasCreacion()
        {
            using (SqlConnection connection = Conexion.GetConnection())
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
            }
        
    

        public DataTable MostrarMaterias()
        {
            using (SqlConnection connection = Conexion.GetConnection())
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
        }

        public void ModificarMateria(string NombreMateria, string MateriaID)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {

                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarMaterias", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "Modificar");
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

        }


        public void EliminarMateria(string MateriaID)
        {
            using (SqlConnection connection = Conexion.GetConnection())
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
        }


        public void CambiarAsignacion(string MateriaID, string DocenteID, int GradoID)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarMaterias", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "CambiarAsignacion");
                    cmd.Parameters.AddWithValue("@MateriaID", MateriaID);
                    cmd.Parameters.AddWithValue("@DocenteID", DocenteID);
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
                        connection.Close();
                }
            }

        }
    
        public void EliminarAsignacion(string MateriaID)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarMaterias", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "EliminarAsignacion");
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


        }

        public void EliminarVinculacion(string MateriaID, int GradoID)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "EliminarMateriaGrado");
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
                        connection.Close();
                }
            }
        }


    }
}
