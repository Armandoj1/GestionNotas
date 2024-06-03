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

        public ProgramaPrincipal()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas cerrar sesión?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
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
                iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            }
            else
            {
                PnlGestionarGrados.Visible = true;
                iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleChevronDown;
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
                iconButton6.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            }
            else
            {
                SubMenuMaterias.Visible = true;
                iconButton6.IconChar = FontAwesome.Sharp.IconChar.CircleChevronDown;
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

        }
    }
}
