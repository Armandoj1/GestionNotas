using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class B_Materias
    {

        DAL.D_Materias materias = new DAL.D_Materias();
        
        public void AgregarMateria(string MateriaID, string NombreMateria)
        {
            materias.AgregarMateria(MateriaID, NombreMateria);
        }

        public DataTable MostrarMaterias()
        {
            return materias.MostrarMaterias();
        }

        public void VincularMateria(string MateriaID, string DocenteID)
        {
            materias.VincularMateria(MateriaID, DocenteID);
        }

        public DataTable MostrarMateriasCreacion()
        {
            return materias.MostrarMateriasCreacion();
        }

        public void ModificarMateria(string NombreMateria, string MateriaID)
        {
            materias.ModificarMateria(NombreMateria, MateriaID);
        }

        public void EliminarMateria(string MateriaID)
        {
            materias.EliminarMateria(MateriaID);
        }

        public void CambiarAsignacion(string MateriaID, string DocenteID)
        {
            materias.CambiarAsignacion(MateriaID, DocenteID);
        }

    }
}
