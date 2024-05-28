namespace PRESENTACION
{
    partial class SubMenuRegistrarMaterias
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
            this.TxtNombreMateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoMateria = new System.Windows.Forms.TextBox();
            this.BtnAgregarMateria = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.CboxDocente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // TxtNombreMateria
            // 
            this.TxtNombreMateria.Location = new System.Drawing.Point(12, 43);
            this.TxtNombreMateria.Name = "TxtNombreMateria";
            this.TxtNombreMateria.Size = new System.Drawing.Size(193, 22);
            this.TxtNombreMateria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código de materia:";
            // 
            // TxtCodigoMateria
            // 
            this.TxtCodigoMateria.Location = new System.Drawing.Point(233, 43);
            this.TxtCodigoMateria.Name = "TxtCodigoMateria";
            this.TxtCodigoMateria.Size = new System.Drawing.Size(172, 22);
            this.TxtCodigoMateria.TabIndex = 3;
            // 
            // BtnAgregarMateria
            // 
            this.BtnAgregarMateria.Location = new System.Drawing.Point(676, 36);
            this.BtnAgregarMateria.Name = "BtnAgregarMateria";
            this.BtnAgregarMateria.Size = new System.Drawing.Size(103, 31);
            this.BtnAgregarMateria.TabIndex = 5;
            this.BtnAgregarMateria.Text = "Agregar";
            this.BtnAgregarMateria.UseVisualStyleBackColor = true;
            this.BtnAgregarMateria.Click += new System.EventHandler(this.BtnAgregarMateria_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(785, 36);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(103, 31);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(894, 36);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(103, 31);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // CboxDocente
            // 
            this.CboxDocente.FormattingEnabled = true;
            this.CboxDocente.Location = new System.Drawing.Point(436, 43);
            this.CboxDocente.Name = "CboxDocente";
            this.CboxDocente.Size = new System.Drawing.Size(186, 24);
            this.CboxDocente.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Docente a asignar:";
            // 
            // SubMenuRegistrarMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 447);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboxDocente);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregarMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigoMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombreMateria);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SubMenuRegistrarMaterias";
            this.Text = "SubMenuRegistrarMaterias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtNombreMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigoMateria;
        private System.Windows.Forms.Button BtnAgregarMateria;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ComboBox CboxDocente;
        private System.Windows.Forms.Label label3;
    }
}