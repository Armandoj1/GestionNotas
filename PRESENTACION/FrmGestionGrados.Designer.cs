namespace PRESENTACION
{
    partial class FrmGestionGrados
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
            this.BtnAgregarGrados = new System.Windows.Forms.Button();
            this.BtnEliminarGrados = new System.Windows.Forms.Button();
            this.Txt_GradoID = new System.Windows.Forms.TextBox();
            this.Txt_NombreGrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_BuscarGrado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 481);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnAgregarGrados
            // 
            this.BtnAgregarGrados.Location = new System.Drawing.Point(572, 21);
            this.BtnAgregarGrados.Name = "BtnAgregarGrados";
            this.BtnAgregarGrados.Size = new System.Drawing.Size(142, 36);
            this.BtnAgregarGrados.TabIndex = 1;
            this.BtnAgregarGrados.Text = "Agregar";
            this.BtnAgregarGrados.UseVisualStyleBackColor = true;
            this.BtnAgregarGrados.Click += new System.EventHandler(this.BtnAgregarGrados_Click);
            // 
            // BtnEliminarGrados
            // 
            this.BtnEliminarGrados.Location = new System.Drawing.Point(396, 21);
            this.BtnEliminarGrados.Name = "BtnEliminarGrados";
            this.BtnEliminarGrados.Size = new System.Drawing.Size(142, 36);
            this.BtnEliminarGrados.TabIndex = 2;
            this.BtnEliminarGrados.Text = "Eliminar";
            this.BtnEliminarGrados.UseVisualStyleBackColor = true;
            // 
            // Txt_GradoID
            // 
            this.Txt_GradoID.Location = new System.Drawing.Point(12, 28);
            this.Txt_GradoID.Name = "Txt_GradoID";
            this.Txt_GradoID.Size = new System.Drawing.Size(142, 22);
            this.Txt_GradoID.TabIndex = 3;
            // 
            // Txt_NombreGrado
            // 
            this.Txt_NombreGrado.Location = new System.Drawing.Point(179, 28);
            this.Txt_NombreGrado.Name = "Txt_NombreGrado";
            this.Txt_NombreGrado.Size = new System.Drawing.Size(142, 22);
            this.Txt_NombreGrado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID del grado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del grado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(874, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar:";
            // 
            // Txt_BuscarGrado
            // 
            this.Txt_BuscarGrado.Location = new System.Drawing.Point(932, 27);
            this.Txt_BuscarGrado.Name = "Txt_BuscarGrado";
            this.Txt_BuscarGrado.Size = new System.Drawing.Size(142, 22);
            this.Txt_BuscarGrado.TabIndex = 9;
            // 
            // FrmGestionGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 583);
            this.Controls.Add(this.Txt_BuscarGrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_NombreGrado);
            this.Controls.Add(this.Txt_GradoID);
            this.Controls.Add(this.BtnEliminarGrados);
            this.Controls.Add(this.BtnAgregarGrados);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmGestionGrados";
            this.Text = "FrmGestionGrados";
            this.Load += new System.EventHandler(this.FrmGestionGrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAgregarGrados;
        private System.Windows.Forms.Button BtnEliminarGrados;
        private System.Windows.Forms.TextBox Txt_GradoID;
        private System.Windows.Forms.TextBox Txt_NombreGrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_BuscarGrado;
    }
}