using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;


namespace PRESENTACION
{
    public partial class Loginc : Form
    {
        E_Usuarios variables = new E_Usuarios();
        B_Usuario cn = new B_Usuario();

        public Loginc()
        {
            InitializeComponent();
            LoadComboBox();
        }

        public void LoadComboBox()
        {
            DataTable tabla = cn.MostarRoles();
            CboxRoles.DataSource = tabla;
            CboxRoles.DisplayMember = "NombreRol";

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int resultado = 1;
            try
            {
                variables.Usuario1 = TxtUsuario.Text;
                variables.Password1 = TxtPassword.Text;
                variables.Rol1 = CboxRoles.Text;

                E_Usuarios.Usuario2 = TxtUsuario.Text;
                E_Usuarios.Rol2 = CboxRoles.Text;

                cn.ValidarUsuario(variables.Usuario1, variables.Password1, variables.Rol1);
                resultado = 2;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(resultado == 2)
                {
                    ProgramaPrincipal principal = new ProgramaPrincipal();
                    this.Hide();
                    principal.Show();
                }
            }

        }
    }
}
