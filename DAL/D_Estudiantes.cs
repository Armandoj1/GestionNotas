using System;
using System.Data;
using System.Data.SqlClient;

public class D_Estudiantes
{
    static string connectionString = "Data Source=sql.holamundodevs.com;Initial Catalog=Jose_NotasDB;User ID=joserodriguez;Password=Holamundo123*;";
    SqlConnection connection = new SqlConnection(connectionString);


    public DataTable ConsultarAlumnos()
    {
        
        string query = "Select * from Estudiantes";
        SqlCommand cmd = new SqlCommand(query, connection);
        SqlDataAdapter data = new SqlDataAdapter(cmd);
        DataTable dataTable = new DataTable();
        data.Fill(dataTable);
        return dataTable;
        
    }

    public void AgregarEstudiante(string nombre, string CC, DateTime fechaNacimiento, string direccion, string telefono)
    {
        try
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("RegistrarEstudiante", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@CC", CC);
            cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@Telefono", telefono);

            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error al agregar el estudiante", ex);
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
            SqlCommand cmd = new SqlCommand("ModificarEstudiante", connection);
            cmd.CommandType = CommandType.StoredProcedure;

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

