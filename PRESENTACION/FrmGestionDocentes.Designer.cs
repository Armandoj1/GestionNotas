namespace PRESENTACION
{
    partial class FrmGestionDocentes
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBuscarCC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBuscarEspecialidad = new System.Windows.Forms.TextBox();
            this.CboxEspecialidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 610);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(12, 39);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(249, 22);
            this.TxtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre completo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cédula:";
            // 
            // TxtCC
            // 
            this.TxtCC.Location = new System.Drawing.Point(289, 39);
            this.TxtCC.Name = "TxtCC";
            this.TxtCC.Size = new System.Drawing.Size(156, 22);
            this.TxtCC.TabIndex = 3;
            this.TxtCC.TextChanged += new System.EventHandler(this.TxtCC_TextChanged);
            this.TxtCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCC_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // PickerNacimiento
            // 
            this.PickerNacimiento.Location = new System.Drawing.Point(460, 39);
            this.PickerNacimiento.Name = "PickerNacimiento";
            this.PickerNacimiento.Size = new System.Drawing.Size(171, 22);
            this.PickerNacimiento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1025, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dirección:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(1022, 39);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(156, 22);
            this.TxtDireccion.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(816, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Especialidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Teléfono:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(648, 39);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(156, 22);
            this.TxtTelefono.TabIndex = 12;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(12, 78);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(127, 30);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(145, 78);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(127, 30);
            this.BtnModificar.TabIndex = 17;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(278, 78);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(127, 30);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 733);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cédula:";
            // 
            // TxtBuscarCC
            // 
            this.TxtBuscarCC.Location = new System.Drawing.Point(365, 730);
            this.TxtBuscarCC.Name = "TxtBuscarCC";
            this.TxtBuscarCC.Size = new System.Drawing.Size(156, 22);
            this.TxtBuscarCC.TabIndex = 21;
            this.TxtBuscarCC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 733);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Especialidad:";
            // 
            // TxtBuscarEspecialidad
            // 
            this.TxtBuscarEspecialidad.Location = new System.Drawing.Point(129, 730);
            this.TxtBuscarEspecialidad.Name = "TxtBuscarEspecialidad";
            this.TxtBuscarEspecialidad.Size = new System.Drawing.Size(132, 22);
            this.TxtBuscarEspecialidad.TabIndex = 19;
            this.TxtBuscarEspecialidad.TextChanged += new System.EventHandler(this.TxtBuscarEspecialidad_TextChanged);
            // 
            // CboxEspecialidad
            // 
            this.CboxEspecialidad.FormattingEnabled = true;
            this.CboxEspecialidad.Location = new System.Drawing.Point(819, 37);
            this.CboxEspecialidad.Name = "CboxEspecialidad";
            this.CboxEspecialidad.Size = new System.Drawing.Size(176, 24);
            this.CboxEspecialidad.TabIndex = 24;
            this.CboxEspecialidad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmGestionDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 776);
            this.Controls.Add(this.CboxEspecialidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtBuscarCC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtBuscarEspecialidad);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.PickerNacimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmGestionDocentes";
            this.Text = "FrmGestionDocentes";
            this.Load += new System.EventHandler(this.FrmGestionDocentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker PickerNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBuscarCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtBuscarEspecialidad;
        private System.Windows.Forms.ComboBox CboxEspecialidad;
    }
}