using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class E_Docentes
    {
        string Nombre;
        string CC;
        string Direccion;
        string Telefono;
        int Especialidad;
        DateTime FechaNacimiento;
        string Correo;


        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string CC1 { get => CC; set => CC = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public int Especialidad1 { get => Especialidad; set => Especialidad = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
    }
}
