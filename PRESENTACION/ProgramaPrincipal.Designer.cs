namespace PRESENTACION
{
    partial class ProgramaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarBoletines = new FontAwesome.Sharp.IconButton();
            this.SubMenuMaterias = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.PnlGestionarGrados = new System.Windows.Forms.Panel();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.BtnAsignarMateriaGrados = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SubMenuMaterias.SuspendLayout();
            this.PnlGestionarGrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerarBoletines);
            this.panel1.Controls.Add(this.SubMenuMaterias);
            this.panel1.Controls.Add(this.iconButton6);
            this.panel1.Controls.Add(this.PnlGestionarGrados);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 807);
            this.panel1.TabIndex = 0;
            // 
            // btnGenerarBoletines
            // 
            this.btnGenerarBoletines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerarBoletines.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarBoletines.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnGenerarBoletines.IconColor = System.Drawing.Color.Black;
            this.btnGenerarBoletines.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarBoletines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarBoletines.Location = new System.Drawing.Point(0, 530);
            this.btnGenerarBoletines.Name = "btnGenerarBoletines";
            this.btnGenerarBoletines.Size = new System.Drawing.Size(219, 54);
            this.btnGenerarBoletines.TabIndex = 20;
            this.btnGenerarBoletines.Text = "Boletines";
            this.btnGenerarBoletines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarBoletines.UseVisualStyleBackColor = true;
            // 
            // SubMenuMaterias
            // 
            this.SubMenuMaterias.Controls.Add(this.BtnAsignarMateriaGrados);
            this.SubMenuMaterias.Controls.Add(this.iconButton5);
            this.SubMenuMaterias.Controls.Add(this.iconButton4);
            this.SubMenuMaterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuMaterias.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMenuMaterias.Location = new System.Drawing.Point(0, 371);
            this.SubMenuMaterias.Name = "SubMenuMaterias";
            this.SubMenuMaterias.Size = new System.Drawing.Size(219, 159);
            this.SubMenuMaterias.TabIndex = 19;
            this.SubMenuMaterias.Visible = false;
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Chalkboard;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 108);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(219, 51);
            this.iconButton5.TabIndex = 3;
            this.iconButton5.Text = "Manipulación de materia";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click_1);
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Chalkboard;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(219, 54);
            this.iconButton4.TabIndex = 2;
            this.iconButton4.Text = "Asignar a docente";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 317);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(219, 54);
            this.iconButton6.TabIndex = 18;
            this.iconButton6.Text = "Gestionar materias";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // PnlGestionarGrados
            // 
            this.PnlGestionarGrados.Controls.Add(this.iconButton8);
            this.PnlGestionarGrados.Controls.Add(this.iconButton7);
            this.PnlGestionarGrados.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlGestionarGrados.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlGestionarGrados.Location = new System.Drawing.Point(0, 207);
            this.PnlGestionarGrados.Name = "PnlGestionarGrados";
            this.PnlGestionarGrados.Size = new System.Drawing.Size(219, 110);
            this.PnlGestionarGrados.TabIndex = 13;
            this.PnlGestionarGrados.Visible = false;
            // 
            // iconButton8
            // 
            this.iconButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.Chalkboard;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 30;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton8.Location = new System.Drawing.Point(0, 54);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(219, 56);
            this.iconButton8.TabIndex = 4;
            this.iconButton8.Text = "Manipulación de grados";
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton8.UseVisualStyleBackColor = true;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // iconButton7
            // 
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Chalkboard;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 30;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton7.Location = new System.Drawing.Point(0, 0);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(219, 54);
            this.iconButton7.TabIndex = 3;
            this.iconButton7.Text = "Asignar grados";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton7.UseVisualStyleBackColor = true;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 153);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(219, 54);
            this.iconButton2.TabIndex = 12;
            this.iconButton2.Text = "Gestionar grados";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 99);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(219, 54);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "Gestionar alumnos";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 45);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(219, 54);
            this.iconButton3.TabIndex = 9;
            this.iconButton3.Text = "Gestionar docentes";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.Location = new System.Drawing.Point(68, 766);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 45);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "GESTIÓN DE NOTAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.ImageLocation = "C:\\Users\\José A. Rodríguez\\source\\repos\\GestionNotas\\GestionNotas\\Iconos\\School B" +
    "uilding.png";
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(219, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1212, 41);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(966, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.ImageLocation = "C:\\Users\\José A. Rodríguez\\source\\repos\\GestionNotas\\GestionNotas\\Iconos\\User.png" +
    "";
            this.pictureBox1.Location = new System.Drawing.Point(1148, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Male User.png");
            this.imageList1.Images.SetKeyName(1, "Registrar.png");
            this.imageList1.Images.SetKeyName(2, "School Building.png");
            this.imageList1.Images.SetKeyName(3, "Shutdown.png");
            this.imageList1.Images.SetKeyName(4, "User.png");
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(219, 41);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1212, 766);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // BtnAsignarMateriaGrados
            // 
            this.BtnAsignarMateriaGrados.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAsignarMateriaGrados.IconChar = FontAwesome.Sharp.IconChar.Chalkboard;
            this.BtnAsignarMateriaGrados.IconColor = System.Drawing.Color.Black;
            this.BtnAsignarMateriaGrados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAsignarMateriaGrados.IconSize = 30;
            this.BtnAsignarMateriaGrados.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnAsignarMateriaGrados.Location = new System.Drawing.Point(0, 54);
            this.BtnAsignarMateriaGrados.Name = "BtnAsignarMateriaGrados";
            this.BtnAsignarMateriaGrados.Size = new System.Drawing.Size(219, 54);
            this.BtnAsignarMateriaGrados.TabIndex = 5;
            this.BtnAsignarMateriaGrados.Text = "Asignar a grados";
            this.BtnAsignarMateriaGrados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAsignarMateriaGrados.UseVisualStyleBackColor = true;
            this.BtnAsignarMateriaGrados.Click += new System.EventHandler(this.BtnAsignarMateriaGrados_Click);
            // 
            // ProgramaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1431, 807);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgramaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.panel1.ResumeLayout(false);
            this.SubMenuMaterias.ResumeLayout(false);
            this.PnlGestionarGrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel PanelPrincipal;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnGenerarBoletines;
        private System.Windows.Forms.Panel SubMenuMaterias;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.Panel PnlGestionarGrados;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton BtnAsignarMateriaGrados;
    }
}