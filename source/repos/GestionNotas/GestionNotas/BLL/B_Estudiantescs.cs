using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class B_Estudiantescs
    {
        D_Estudiantes estudiante = new D_Estudiantes();


        public DataTable ConsultarEstudiantes()
        {
            return estudiante.ConsultarAlumnos();
        }

        public DataTable BuscarAlumno(string CC)
        {
            return estudiante.BuscarAlumno(CC);
        }
        public void AgregarEstudiante(string nombre, string CC, DateTime FechaNacimiento, string direccion, string telefono)
        {
         
            estudiante.AgregarEstudiante(nombre, CC, FechaNacimiento, direccion, telefono);

        }

        public void ModificarEstudiante(string nombre, string CC, DateTime FechaNacimiento, string direccion, string telefono)
        {
            estudiante.ModificarEstudiante(nombre, CC, FechaNacimiento, direccion, telefono);
        }

        public void EliminarEstudiante(string cc)
        {
            estudiante.EliminarEstudiante(cc);
        }


    }
}
