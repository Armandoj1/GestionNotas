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
        public void AgregarMateria(string MateriaID, string NombreMateria, string DocenteID)
        {
            materias.AgregarMateria(MateriaID, NombreMateria, DocenteID);
        }

        public DataTable MostrarMaterias()
        {
            return materias.MostrarMaterias();
        }



    }
}
