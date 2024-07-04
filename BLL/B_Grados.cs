using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_Grados
    {

        D_Grados grados = new D_Grados();
        public void AgregarGrado(string NombreGrado)
        {
            grados.AgregarGrado(NombreGrado);
        }

        public void VincularGrado(string EstudianteID, int GradoID)
        {
            grados.VincularGrado(EstudianteID, GradoID);
        }
        public DataTable MostrarGrados()
        {

            return grados.MostrarGrados();

        }
        public DataTable ListarGrados()
        {
            return grados.ListarGrados();
        }

        public DataTable MostrarEstudiantes()
        {
            return grados.MostrarEstudiantes();
        }


        public void Modificar(int GradoID, string EstudianteCC)
        {
            grados.Modificar(GradoID, EstudianteCC);
        }

        public DataTable MostrarConGrados()
        {
            return grados.MostrarModificar();
        }

        public void CambiarNombreGrado(string NombreGrado, int GradoID)
        {
            grados.CambiarNombreGrado(NombreGrado, GradoID);
        }

        public void EliminarEstudianteGrado(string EstudianteCC)
        {
            grados.EliminarEstudianteGrado(EstudianteCC);
        }



    }
}