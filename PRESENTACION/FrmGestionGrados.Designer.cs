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
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_GradoID = new System.Windows.Forms.TextBox();
            this.BtnEliminarGrados = new System.Windows.Forms.Button();
            this.BtnAgregarGrados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCCEstudiante = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.DgvEstudiantesConGrados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiantesConGrados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(280, 664);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre del grado: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_GradoID
            // 
            this.Txt_GradoID.Enabled = false;
            this.Txt_GradoID.Location = new System.Drawing.Point(162, 16);
            this.Txt_GradoID.Name = "Txt_GradoID";
            this.Txt_GradoID.Size = new System.Drawing.Size(130, 22);
            this.Txt_GradoID.TabIndex = 49;
            // 
            // BtnEliminarGrados
            // 
            this.BtnEliminarGrados.Location = new System.Drawing.Point(748, 12);
            this.BtnEliminarGrados.Name = "BtnEliminarGrados";
            this.BtnEliminarGrados.Size = new System.Drawing.Size(149, 30);
            this.BtnEliminarGrados.TabIndex = 48;
            this.BtnEliminarGrados.Text = "Desvincular grado";
            this.BtnEliminarGrados.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarGrados
            // 
            this.BtnAgregarGrados.Location = new System.Drawing.Point(583, 12);
            this.BtnAgregarGrados.Name = "BtnAgregarGrados";
            this.BtnAgregarGrados.Size = new System.Drawing.Size(159, 30);
            this.BtnAgregarGrados.TabIndex = 47;
            this.BtnAgregarGrados.Text = "Vincular grado";
            this.BtnAgregarGrados.UseVisualStyleBackColor = true;
            this.BtnAgregarGrados.Click += new System.EventHandler(this.BtnAgregarGrados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 728);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Buscar grados: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 725);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 22);
            this.textBox1.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Estudiante:";
            // 
            // TxtCCEstudiante
            // 
            this.TxtCCEstudiante.Enabled = false;
            this.TxtCCEstudiante.Location = new System.Drawing.Point(409, 16);
            this.TxtCCEstudiante.Name = "TxtCCEstudiante";
            this.TxtCCEstudiante.Size = new System.Drawing.Size(142, 22);
            this.TxtCCEstudiante.TabIndex = 53;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(324, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(876, 664);
            this.dataGridView2.TabIndex = 55;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(1040, 12);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(160, 30);
            this.BtnModificar.TabIndex = 56;
            this.BtnModificar.Text = "Cambiar de grado";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Location = new System.Drawing.Point(903, 12);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(131, 30);
            this.BtnCambiar.TabIndex = 57;
            this.BtnCambiar.Text = "Modificar grado";
            this.BtnCambiar.UseVisualStyleBackColor = true;
            this.BtnCambiar.Visible = false;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // DgvEstudiantesConGrados
            // 
            this.DgvEstudiantesConGrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstudiantesConGrados.Location = new System.Drawing.Point(324, 48);
            this.DgvEstudiantesConGrados.Name = "DgvEstudiantesConGrados";
            this.DgvEstudiantesConGrados.RowHeadersWidth = 51;
            this.DgvEstudiantesConGrados.RowTemplate.Height = 24;
            this.DgvEstudiantesConGrados.Size = new System.Drawing.Size(876, 664);
            this.DgvEstudiantesConGrados.TabIndex = 58;
            this.DgvEstudiantesConGrados.Visible = false;
            this.DgvEstudiantesConGrados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstudiantesConGrados_CellClick);
            // 
            // FrmGestionGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 786);
            this.Controls.Add(this.DgvEstudiantesConGrados);
            this.Controls.Add(this.BtnCambiar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCCEstudiante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_GradoID);
            this.Controls.Add(this.BtnEliminarGrados);
            this.Controls.Add(this.BtnAgregarGrados);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmGestionGrados";
            this.Text = "FrmGestionGrados";
            this.Load += new System.EventHandler(this.FrmGestionGrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiantesConGrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_GradoID;
        private System.Windows.Forms.Button BtnEliminarGrados;
        private System.Windows.Forms.Button BtnAgregarGrados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCCEstudiante;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.DataGridView DgvEstudiantesConGrados;
    }
}