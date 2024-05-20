using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Estudiantescs
    {
        DAL_Estudiantes estudiante = new DAL_Estudiantes();

        public void AgregarEstudiante(string nombre, string CC, DateTime FechaNacimiento, string direccion, string telefono)
        {
         
            estudiante.AgregarEstudiante(nombre, CC, FechaNacimiento, direccion, telefono);

        }


    }
}
