using System;
using System.Data;
using System.Data.SqlClient;

public class D_Estudiantes
{
    static string connectionString = "Data Source=sql.holamundodevs.com;Initial Catalog=Jose_NotasDB;User ID=joserodriguez;Password=Holamundo123*;";
    SqlConnection connection = new SqlConnection(connectionString);


    public DataTable ConsultarAlumnos()
    {
            try
            {
                SqlCommand cmd = new SqlCommand("GestionarAlumnos", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "Mostrar"); 

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al consultar los alumnos." + ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


    
    public DataTable BuscarAlumno(string CC)
    {
        try
        {
            using (SqlCommand command = new SqlCommand("GestionarAlumnos", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Accion", "FiltrarAlumno");
                command.Parameters.AddWithValue("@CC", CC);
                connection.Open();
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
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }

    public DataTable BuscarAlumnoGrado(string Grado)
    {
        try
        {
            using (SqlCommand command = new SqlCommand("GestionarAlumnos", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Grado", Grado);
                command.Parameters.AddWithValue("@Accion", "FiltrarAlumnoGrado");
                connection.Open();
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
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }



    public void EliminarEstudiante(string CC)
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

    
    public void AgregarEstudiante(string nombre, string CC, DateTime fechaNacimiento, string direccion, string telefono)
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


    public void ModificarEstudiante(string nombre, string CC, DateTime FechaNacimiento, string Direccion, string Telefono)
    {
        try
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("GestionarAlumnos", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Accion", "Modificar");
            cmd.Parameters.AddWithValue("@Nombre", nombre );
            cmd.Parameters.AddWithValue("@CC", CC );
            cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            cmd.Parameters.AddWithValue("@Direccion", Direccion);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
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

