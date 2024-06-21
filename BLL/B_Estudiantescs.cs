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


    
        public DataTable BuscarAlumnoGrado(string Grado)
        {
            return estudiante.BuscarAlumnoGrado(Grado);
        }
        public void AgregarEstudiante(string nombre, string CC, DateTime FechaNacimiento, string direccion, string telefono, string Correo)
        {
         
            estudiante.AgregarEstudiante (CC, nombre, FechaNacimiento, direccion, telefono, Correo);

        }

        public void ModificarEstudiante(string nombre, string CC, DateTime FechaNacimiento, string direccion, string telefono, string Correo)
        {
            estudiante.ModificarEstudiante(nombre, CC, FechaNacimiento, direccion, telefono, Correo);
        }

        public void EliminarEstudiante(string cc)
        {
            estudiante.EliminarEstudiante(cc);
        }


    }
}
