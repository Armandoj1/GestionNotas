using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_GestionNotas
    {
        D_RegistroNotas notas = new D_RegistroNotas();

        public DataTable MostrarNotas(int GradoID)
        {
            return notas.MostrarNotas(GradoID);
        }

        public void RegistrarNotas(string EstudianteCC, string MateriaID, int Periodo, decimal nota, string Observacion)
        {
            notas.RegistrarNotas(EstudianteCC, MateriaID, Periodo, nota, Observacion);
        }

        public void ModificarNota(string EstudianteCC, string MateriaID, int Periodo, decimal nota, string Observacion)
        {
            notas.ModificarNota(EstudianteCC, MateriaID, Periodo, nota, Observacion);
        }
        }
}
