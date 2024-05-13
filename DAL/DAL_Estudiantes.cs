using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Estudiantes
    {
        static string connectionString = "Data Source=sql.holamundodevs.com;Initial Catalog=Jose_NotasDB;User ID=joserodriguez;Password=Holamundo123*;";
        SqlConnection connection = new SqlConnection(connectionString);
        
        public string AgregarEstudiante(string nombre, string CC, string FechaNacimiento, string direccion, string telefono)
        {
            connection.Open();
            string query = "INSERT INTO Estudiantes (Nombre, CC, FechaNacimiento, Direccion, Telefono) values" +
                " '"+nombre+"', '"+CC+"', '"+FechaNacimiento+"', '"+direccion+"', '"+telefono+"' ";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            return query;

        }





    }
}
