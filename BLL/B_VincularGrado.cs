﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_VincularGrado
    {
        D_VincularGrados vinculo = new D_VincularGrados();
        public void AgregarGrado(string CC, string GradoID)
        {
            vinculo.AgregarGrado(CC, GradoID);
        }

        public void ModificarGrado(string GradoID, string CC)
        {
            vinculo.ModificarGrado(GradoID, CC);

        }

        public void EliminarGrado(string CC)
        {
            vinculo.EliminarEstudianteGrado(CC);
        }


    }

}
