using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_Usuario
    {

        D_Usuarios usuario = new D_Usuarios();
        public void ValidarUsuario(string Usuario, string Password, string Rol)
        {
           usuario.ValidarUsuario(Usuario, Password, Rol);

        }

        public DataTable MostarRoles()
        {
            return usuario.MostarRoles();
        }

        public DataTable ValidarUsuarioDocente(string Usuario)
        {
            return usuario.ValidarUsuarioDocente(Usuario);
        }

    }
}
