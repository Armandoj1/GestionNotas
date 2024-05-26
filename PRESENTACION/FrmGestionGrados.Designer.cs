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
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 457);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnAgregarGrados
            // 
            this.BtnAgregarGrados.Location = new System.Drawing.Point(12, 376);
            this.BtnAgregarGrados.Name = "BtnAgregarGrados";
            this.BtnAgregarGrados.Size = new System.Drawing.Size(142, 36);
            this.BtnAgregarGrados.TabIndex = 1;
            this.BtnAgregarGrados.Text = "Agregar";
            this.BtnAgregarGrados.UseVisualStyleBackColor = true;
            this.BtnAgregarGrados.Click += new System.EventHandler(this.BtnAgregarGrados_Click);
            // 
            // BtnEliminarGrados
            // 
            this.BtnEliminarGrados.Location = new System.Drawing.Point(12, 418);
            this.BtnEliminarGrados.Name = "BtnEliminarGrados";
            this.BtnEliminarGrados.Size = new System.Drawing.Size(142, 36);
            this.BtnEliminarGrados.TabIndex = 2;
            this.BtnEliminarGrados.Text = "Eliminar";
            this.BtnEliminarGrados.UseVisualStyleBackColor = true;
            // 
            // Txt_GradoID
            // 
            this.Txt_GradoID.Location = new System.Drawing.Point(12, 37);
            this.Txt_GradoID.Name = "Txt_GradoID";
            this.Txt_GradoID.Size = new System.Drawing.Size(142, 22);
            this.Txt_GradoID.TabIndex = 3;
            // 
            // Txt_NombreGrado
            // 
            this.Txt_NombreGrado.Location = new System.Drawing.Point(12, 109);
            this.Txt_NombreGrado.Name = "Txt_NombreGrado";
            this.Txt_NombreGrado.Size = new System.Drawing.Size(142, 22);
            this.Txt_NombreGrado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID del grado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del grado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1178, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar:";
            // 
            // Txt_BuscarGrado
            // 
            this.Txt_BuscarGrado.Location = new System.Drawing.Point(1088, 27);
            this.Txt_BuscarGrado.Name = "Txt_BuscarGrado";
            this.Txt_BuscarGrado.Size = new System.Drawing.Size(142, 22);
            this.Txt_BuscarGrado.TabIndex = 9;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(12, 476);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(142, 36);
            this.Btn_Cerrar.TabIndex = 10;
            this.Btn_Cerrar.Text = "Cerrar pestaña";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // FrmGestionGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 583);
            this.Controls.Add(this.Btn_Cerrar);
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
        private System.Windows.Forms.Button Btn_Cerrar;
    }
}