using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using DAL;
public class D_Estudiantes
{
    public DataTable ConsultarAlumnos()
    {
        using (SqlConnection connection = Conexion.GetConnection())
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GestionarAlumnos", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Accion", "Mostrar");
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable tabla = new DataTable();
                dataAdapter.Fill(tabla);
                return tabla;
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }
    }


    public DataTable BuscarAlumno(string CC)
    {
        using (SqlConnection connection = Conexion.GetConnection())
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GestionarAlumnos", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Accion", "FiltrarAlumno");
                command.Parameters.AddWithValue("@CC", CC);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable tabla = new DataTable();
                dataAdapter.Fill(tabla);
                return tabla;
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }
    }

    
    public DataTable BuscarAlumnoGrado(string Grado)
    {
        using (SqlConnection connection = Conexion.GetConnection())
        {
            try
            {
                using (SqlCommand command = new SqlCommand("GestionarAlumnos", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Grado", Grado);
                    command.Parameters.AddWithValue("@Accion", "FiltrarAlumnoGrado");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable tabla = new DataTable();
                    dataAdapter.Fill(tabla);
                    return tabla;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }




    public void EliminarEstudiante(string CC)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarAlumnos", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "Eliminar");
                    cmd.Parameters.AddWithValue("@CC", CC);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error: ", ex);
                }
                finally
                {

                    connection.Close();

                }
            }

        }


    public void AgregarEstudiante(string nombre, string CC, DateTime fechaNacimiento, string direccion, string telefono, string Correo)
    {
        using (SqlConnection connection = Conexion.GetConnection())
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarAlumnos", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "Registrar");
                cmd.Parameters.AddWithValue("@CC", CC);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Correo" , Correo);


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
    }


        public void ModificarEstudiante(string nombre, string CC, DateTime FechaNacimiento, string Direccion, string Telefono, string Correo)
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GestionarAlumnos", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accion", "Modificar");
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@CC", CC);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Correo", Correo);
                    cmd.ExecuteNonQuery();


                }
                catch (Exception ex)
                {

                    throw new ApplicationException(ex.Message, ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }




    }

