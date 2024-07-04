using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class E_Grados
    {
        private int gradoID;
        private string nombreGrado;
        private string estudianteID;

        public int GradoID { get => gradoID; set => gradoID = value; }
        public string NombreGrado { get => nombreGrado; set => nombreGrado = value; }
        public string EstudianteID { get => estudianteID; set => estudianteID = value; }
    }
}
