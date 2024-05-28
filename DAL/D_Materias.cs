using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class D_Materias
    {

        static string connectionString = "Data Source=sql.holamundodevs.com;Initial Catalog=Jose_NotasDB;User ID=joserodriguez;Password=Holamundo123*;";
        SqlConnection connection = new SqlConnection(connectionString);

        public void AgregarMateria(string MateriaID, string NombreMateria, string DocenteID)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GestionarMaterias", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accion", "AgregarMateria");
                cmd.Parameters.AddWithValue("@MateriaID", MateriaID);
                cmd.Parameters.AddWithValue("@NombreMateria", NombreMateria);
                cmd.Parameters.AddWithValue("@DocenteID", DocenteID);

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

                throw new ApplicationException ("Error: " + ex.Message);
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }

        

    }
}
