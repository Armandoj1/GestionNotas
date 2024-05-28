using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_Grados
    {
        static string connectionString = "Data Source=sql.holamundodevs.com;Initial Catalog=Jose_NotasDB;User ID=joserodriguez;Password=Holamundo123*;";
        SqlConnection connection = new SqlConnection(connectionString);

        public DataTable ListarGrados()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("GestionarAlumnos", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Accion", "MostrarGrados");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores (puedes registrar el error o lanzar una excepción)
                    throw new Exception("Error al obtener los grados: " + ex.Message);
                }
            }

            return dataTable;
        }


            public void AgregarGrado(string GradoID, string NombreGrado)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarGrados", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "Insertar");
                cmd.Parameters.AddWithValue("@GradoID", GradoID);
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
            cmd.Parameters.AddWithValue("@Accion", "Mostrar");
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            return dataTable;

        }

    }
}
