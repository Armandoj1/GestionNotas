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
        public void AgregarDocente(string Nombre, string CC, DateTime FechaNacimiento, string Direccion, int Especialidad, string Telefono, string Correo)
        {
            docentes.AgregarDocente(Nombre, CC, FechaNacimiento, Direccion, Especialidad, Telefono, Correo);
        }

        public DataTable MostrarDocentes()
        {
            return docentes.MostrarDocentes();   
        }

        public void ModificarDocente(String CC, string Nombre, DateTime FechaNacimiento, string Direccion, int Especialidad, string Telefono, string Correo)
        {
            docentes.ModificarDocente(CC, Nombre, FechaNacimiento, Direccion, Especialidad, Telefono, Correo);
        }

        public DataTable MostrarDocentesCedula(string CC)
        {
            return docentes.MostrarDocentesCedula(CC);
        }

        public DataTable MostrarDocentesEspecialidad(string Especialidad)
        {
            return docentes.MostrarDocentesEspecialidad(Especialidad);
        }

        public void EliminarDocente(string CC)
        {
            docentes.EliminarDocente(CC);
        }

        public DataTable MostrarEspecialidad()
        {
            return docentes.MostrarEspecialidad();
        }

        public void AgregarEspecialidad(string NombreEspecialidad)
        {
            docentes.AgregarEspecialidad(NombreEspecialidad);
        }



    }

    }

