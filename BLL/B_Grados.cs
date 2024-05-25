using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_Grados
    {

        D_Grados grados = new D_Grados();
        public void AgregarGrado(string GradoID, string NombreGrado)
        {
            grados.AgregarGrado(GradoID, NombreGrado);
        }

        public DataTable MostrarGrados()
        {

            return grados.MostrarGrados();

        }

     





        }





}