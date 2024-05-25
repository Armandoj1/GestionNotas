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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.PickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificarEstudiante = new System.Windows.Forms.Button();
            this.TxtCCBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_AsignarGrado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 473);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "CC:";
            // 
            // TxtCC
            // 
            this.TxtCC.Location = new System.Drawing.Point(12, 86);
            this.TxtCC.Name = "TxtCC";
            this.TxtCC.Size = new System.Drawing.Size(218, 22);
            this.TxtCC.TabIndex = 3;
            this.TxtCC.TextChanged += new System.EventHandler(this.TxtCC_TextChanged);
            this.TxtCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCC_KeyPress);
            this.TxtCC.Leave += new System.EventHandler(this.TxtCC_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dirección:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(12, 209);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(218, 22);
            this.TxtDireccion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfono";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(12, 264);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(218, 22);
            this.TxtTelefono.TabIndex = 9;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            this.TxtTelefono.Leave += new System.EventHandler(this.TxtTelefono_Leave);
            // 
            // PickerNacimiento
            // 
            this.PickerNacimiento.Location = new System.Drawing.Point(12, 157);
            this.PickerNacimiento.Name = "PickerNacimiento";
            this.PickerNacimiento.Size = new System.Drawing.Size(218, 22);
            this.PickerNacimiento.TabIndex = 11;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(12, 312);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(218, 34);
            this.BtnAgregar.TabIndex = 12;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificarEstudiante
            // 
            this.BtnModificarEstudiante.Location = new System.Drawing.Point(12, 352);
            this.BtnModificarEstudiante.Name = "BtnModificarEstudiante";
            this.BtnModificarEstudiante.Size = new System.Drawing.Size(218, 34);
            this.BtnModificarEstudiante.TabIndex = 13;
            this.BtnModificarEstudiante.Text = "Modificar";
            this.BtnModificarEstudiante.UseVisualStyleBackColor = true;
            this.BtnModificarEstudiante.Click += new System.EventHandler(this.BtnModificarEstudiante_Click);
            // 
            // TxtCCBuscar
            // 
            this.TxtCCBuscar.Location = new System.Drawing.Point(1049, 6);
            this.TxtCCBuscar.Name = "TxtCCBuscar";
            this.TxtCCBuscar.Size = new System.Drawing.Size(218, 22);
            this.TxtCCBuscar.TabIndex = 14;
            this.TxtCCBuscar.TextChanged += new System.EventHandler(this.TxtCCBuscar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(926, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cédula a buscar:";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(12, 392);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(218, 34);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(12, 473);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(218, 34);
            this.Btn_Cerrar.TabIndex = 17;
            this.Btn_Cerrar.Text = "Cerrar pestaña";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_AsignarGrado
            // 
            this.Btn_AsignarGrado.Location = new System.Drawing.Point(12, 432);
            this.Btn_AsignarGrado.Name = "Btn_AsignarGrado";
            this.Btn_AsignarGrado.Size = new System.Drawing.Size(218, 34);
            this.Btn_AsignarGrado.TabIndex = 18;
            this.Btn_AsignarGrado.Text = "Asignar grado";
            this.Btn_AsignarGrado.UseVisualStyleBackColor = true;
            this.Btn_AsignarGrado.Click += new System.EventHandler(this.Btn_AsignarGrado_Click);
            // 
            // FrmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 523);
            this.Controls.Add(this.Btn_AsignarGrado);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCCBuscar);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.DateTimePicker PickerNacimiento;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificarEstudiante;
        private System.Windows.Forms.TextBox TxtCCBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_AsignarGrado;
    }
}