using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class E_Usuarios
    {

        string Usuario; 
        string Password;
        string Rol;

        private static string usuario2;
        private static string rol2;

        public string Usuario1 { get => Usuario; set => Usuario = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Rol1 { get => Rol; set => Rol = value; }
        public static string Usuario2 { get => usuario2; set => usuario2 = value; }
        public static string Rol2 { get => rol2; set => rol2 = value; }
    }
}
