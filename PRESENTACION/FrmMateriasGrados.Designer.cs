namespace PRESENTACION
{
    partial class FrmMateriasGrados
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
            this.CboxMateriaID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboxGradoID = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregarMateria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CboxMateriaID
            // 
            this.CboxMateriaID.FormattingEnabled = true;
            this.CboxMateriaID.Location = new System.Drawing.Point(13, 50);
            this.CboxMateriaID.Name = "CboxMateriaID";
            this.CboxMateriaID.Size = new System.Drawing.Size(186, 24);
            this.CboxMateriaID.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Grado a asignar:";
            // 
            // CboxGradoID
            // 
            this.CboxGradoID.FormattingEnabled = true;
            this.CboxGradoID.Location = new System.Drawing.Point(228, 50);
            this.CboxGradoID.Name = "CboxGradoID";
            this.CboxGradoID.Size = new System.Drawing.Size(186, 24);
            this.CboxGradoID.TabIndex = 16;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(891, 43);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(103, 31);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(782, 43);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(103, 31);
            this.BtnModificar.TabIndex = 14;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarMateria
            // 
            this.BtnAgregarMateria.Location = new System.Drawing.Point(673, 43);
            this.BtnAgregarMateria.Name = "BtnAgregarMateria";
            this.BtnAgregarMateria.Size = new System.Drawing.Size(103, 31);
            this.BtnAgregarMateria.TabIndex = 13;
            this.BtnAgregarMateria.Text = "Agregar";
            this.BtnAgregarMateria.UseVisualStyleBackColor = true;
            this.BtnAgregarMateria.Click += new System.EventHandler(this.BtnAgregarMateria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Materia para asignar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1555, 806);
            this.dataGridView1.TabIndex = 11;
            // 
            // FrmMateriasGrados
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1579, 945);
            this.Controls.Add(this.CboxMateriaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboxGradoID);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregarMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMateriasGrados";
            this.Text = "FrmMateriasGrados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboxMateriaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboxGradoID;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregarMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}