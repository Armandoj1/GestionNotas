using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{


 
    
    public partial class ProgramaPrincipal : Form
    {
        

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private Form currentForm = null; // Variable para almacenar el formulario actual



        public void MostrarBotones()
        {
            if (LblCargo.Text == "Directivo")
            {
                BtnGestionarDocentes.Visible = true;
                BtnGestionarAlumnos.Visible = true;
                BtnGestionarGrados.Visible = true;
                BtnGestionarMaterias.Visible = true;
                BtnGestionarDocentes.Visible = true;
                BtnBoletin.Visible = true;
                btnGenerarBoletines.Visible = false;
                BtnImprimirBoletin.Visible = true;
            }
            else if (LblCargo.Text == "Docente")
            {
                BtnGestionarDocentes.Visible = false;
                BtnGestionarAlumnos.Visible = false;
                BtnGestionarGrados.Visible = false;
                BtnGestionarMaterias.Visible = false;
                BtnGestionarDocentes.Visible = false;
                BtnBoletin.Visible = false;
                btnGenerarBoletines.Visible = true;

            }

            }

        public ProgramaPrincipal()
        {
            InitializeComponent();
            Lbl_Usuario.Text = E_Usuarios.Usuario2;
            LblCargo.Text = E_Usuarios.Rol2;
            MostrarBotones();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas cerrar sesión?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Hide();
                Loginc login = new Loginc();
                login.Show();
                
            }
            
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                if (currentForm.GetType() == childForm.GetType())
                {
                    // Si el formulario que se intenta abrir ya está abierto, no hacer nada
                    return;
                }
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(childForm);
            PanelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        

    
    private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmEstudiantes());
        }




        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (PnlGestionarGrados.Visible == true)
            {
                PnlGestionarGrados.Visible = false;
                BtnGestionarGrados.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            }
            else
            {
                PnlGestionarGrados.Visible = true;
                BtnGestionarGrados.IconChar = FontAwesome.Sharp.IconChar.CircleChevronDown;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGestionDocentes());

            
        }

   

    private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubMenuAsignarMaterias());
        }

        private void iconButton5_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new SubMenuCrearMaterias());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (SubMenuMaterias.Visible == true)
            {
                SubMenuMaterias.Visible = false;
                BtnGestionarMaterias.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            }
            else
            {
                SubMenuMaterias.Visible = true;
                BtnGestionarMaterias.IconChar = FontAwesome.Sharp.IconChar.CircleChevronDown;
            }
        }

        
        private void iconButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGestionGrados());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm (new FrmCrearGrados());
        }

        private void BtnAsignarMateriaGrados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMateriasGrados());
        }

        private void btnGenerarBoletines_Click(object sender, EventArgs e)
        {
            OpenChildForm (new FrmRegistrarNotas());
        }

        public void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBoletin_Click(object sender, EventArgs e)
        {
            OpenChildForm (new FrmBoletines());
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
           OpenChildForm(new ImprimirBoletin());
        }
    }
}
