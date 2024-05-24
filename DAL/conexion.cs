using System;
using System.Data.SqlClient;



namespace DAL
{
    public class Conexion
    {
        public void Abrir()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source = sql.holamundodevs.com; Initial Catalog = Jose_NotasDB; User ID = joserodriguez; Password = Holamundo123*");
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        public void Cerrar()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source = sql.holamundodevs.com; Initial Catalog = Jose_NotasDB; User ID = joserodriguez; Password = Holamundo123*");
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }


    }
}
