using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;


namespace BLL
{
    public class Testeo
    {
        Conexion estado = new Conexion();
        public void Conexion()
        {

            //if (estado.Conectar() == true)
            //{
            //    MessageBox.Show("Conexión abierta", "Estado de conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //else
            //{
            //    MessageBox.Show("No se ha podido establecer una conexión en la base de datos.", "Estado de conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

        }


    }
}
