using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_GestionDocentes
    {
        DAL.D_GestionDocentes docentes = new DAL.D_GestionDocentes();
        public void AgregarDocente(string Nombre, string CC, DateTime FechaNacimiento, string Telefono, string Especialidad, string Direccion)
        {
            docentes.AgregarDocente(Nombre, CC, FechaNacimiento, Telefono, Especialidad, Direccion);
        }

        public DataTable MostrarDocentes()
        {
            return docentes.MostrarDocentes();   
        }


    }
}
