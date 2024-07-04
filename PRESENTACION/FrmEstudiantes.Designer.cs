namespace PRESENTACION
{
    partial class FrmEstudiantes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificarEstudiante = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.PickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtGradoBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCCBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1550, 795);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // TxtNombreCompleto
            // 
            this.TxtNombreCompleto.Location = new System.Drawing.Point(12, 31);
            this.TxtNombreCompleto.Name = "TxtNombreCompleto";
            this.TxtNombreCompleto.Size = new System.Drawing.Size(218, 22);
            this.TxtNombreCompleto.TabIndex = 1;
            this.TxtNombreCompleto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre completo:";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(1432, 59);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(130, 34);
            this.Btn_Cerrar.TabIndex = 34;
            this.Btn_Cerrar.Text = "Cerrar pestaña";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click_1);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(317, 59);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(133, 34);
            this.BtnEliminar.TabIndex = 33;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click_1);
            // 
            // BtnModificarEstudiante
            // 
            this.BtnModificarEstudiante.Location = new System.Drawing.Point(165, 59);
            this.BtnModificarEstudiante.Name = "BtnModificarEstudiante";
            this.BtnModificarEstudiante.Size = new System.Drawing.Size(133, 34);
            this.BtnModificarEstudiante.TabIndex = 32;
            this.BtnModificarEstudiante.Text = "Modificar";
            this.BtnModificarEstudiante.UseVisualStyleBackColor = true;
            this.BtnModificarEstudiante.Click += new System.EventHandler(this.BtnModificarEstudiante_Click_1);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(12, 59);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(133, 34);
            this.BtnAgregar.TabIndex = 31;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // PickerNacimiento
            // 
            this.PickerNacimiento.Location = new System.Drawing.Point(858, 31);
            this.PickerNacimiento.Name = "PickerNacimiento";
            this.PickerNacimiento.Size = new System.Drawing.Size(218, 22);
            this.PickerNacimiento.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Teléfono";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(670, 31);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(169, 22);
            this.TxtTelefono.TabIndex = 28;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress_1);
            this.TxtTelefono.Leave += new System.EventHandler(this.TxtTelefono_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Dirección:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(446, 31);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(218, 22);
            this.TxtDireccion.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "CC:";
            // 
            // TxtCC
            // 
            this.TxtCC.Location = new System.Drawing.Point(261, 31);
            this.TxtCC.Name = "TxtCC";
            this.TxtCC.Size = new System.Drawing.Size(161, 22);
            this.TxtCC.TabIndex = 23;
            this.TxtCC.TextChanged += new System.EventHandler(this.TxtCC_TextChanged_1);
            this.TxtCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCC_KeyPress_1);
            this.TxtCC.Leave += new System.EventHandler(this.TxtCC_Leave_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 915);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Grado a buscar:";
            // 
            // TxtGradoBuscar
            // 
            this.TxtGradoBuscar.Location = new System.Drawing.Point(162, 912);
            this.TxtGradoBuscar.Name = "TxtGradoBuscar";
            this.TxtGradoBuscar.Size = new System.Drawing.Size(152, 22);
            this.TxtGradoBuscar.TabIndex = 39;
            this.TxtGradoBuscar.TextChanged += new System.EventHandler(this.TxtGradoBuscar_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 915);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Cédula a buscar:";
            // 
            // TxtCCBuscar
            // 
            this.TxtCCBuscar.Location = new System.Drawing.Point(547, 912);
            this.TxtCCBuscar.Name = "TxtCCBuscar";
            this.TxtCCBuscar.Size = new System.Drawing.Size(157, 22);
            this.TxtCCBuscar.TabIndex = 37;
            this.TxtCCBuscar.TextChanged += new System.EventHandler(this.TxtCCBuscar_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1254, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 43;
            this.button1.Text = "Limpiar casillas ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(1104, 31);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(308, 22);
            this.TxtCorreo.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1101, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Correo electrónico:";
            // 
            // FrmEstudiantes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1579, 945);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtGradoBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCCBuscar);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificarEstudiante);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.PickerNacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombreCompleto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEstudiantes";
            this.Text = "FrmEstudiantes";
            this.Load += new System.EventHandler(this.FrmEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtNombreCompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificarEstudiante;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DateTimePicker PickerNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtGradoBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCCBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label8;
    }
}