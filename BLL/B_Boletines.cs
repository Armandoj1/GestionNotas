using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_Boletines
    {

        D_Boletines Boletines = new D_Boletines();

        public DataTable MostrarBoletin()
        {
            return Boletines.MostrarBoletines();
        }

        public DataTable MostrarBoletinesGrados(int GradoID)
        {
            return Boletines.MostrarBoletinesGrados(GradoID);
        }


        public DataTable MostrarBoletinesGradosManual(string GradoID)
        {
            return Boletines.MostrarBoletinesGradosManual(GradoID);
        }


        public DataTable MostrarBoletinesEstudiantes(string EstudianteID)
        {
            return Boletines.MostrarBoletinesCedula(EstudianteID);
        }

        public DataTable MostrarBoletinesMateria(string MateriaID)
        {
            return Boletines.MostrarBoletinesMateria(MateriaID);
        }

        public DataTable MostrarBoletinesMateriaManual(string NombreMateria)
        {
            return Boletines.MostrarBoletinesMateriaManual(NombreMateria);
        }



    }
}
