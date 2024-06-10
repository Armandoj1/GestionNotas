namespace PRESENTACION
{
    partial class FrmRegistrarNotas
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
            this.CboxGrado = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSubirNotas = new System.Windows.Forms.Button();
            this.CboxMateria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboxGrado
            // 
            this.CboxGrado.FormattingEnabled = true;
            this.CboxGrado.Location = new System.Drawing.Point(168, 44);
            this.CboxGrado.Name = "CboxGrado";
            this.CboxGrado.Size = new System.Drawing.Size(121, 24);
            this.CboxGrado.TabIndex = 0;
            this.CboxGrado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CboxGrado_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1555, 856);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el grado: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1579, 35);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1579, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "REGISTRO DE NOTAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSubirNotas
            // 
            this.BtnSubirNotas.Location = new System.Drawing.Point(1126, 42);
            this.BtnSubirNotas.Name = "BtnSubirNotas";
            this.BtnSubirNotas.Size = new System.Drawing.Size(117, 30);
            this.BtnSubirNotas.TabIndex = 4;
            this.BtnSubirNotas.Text = "Subir notas";
            this.BtnSubirNotas.UseVisualStyleBackColor = true;
            this.BtnSubirNotas.Click += new System.EventHandler(this.BtnSubirNotas_Click);
            // 
            // CboxMateria
            // 
            this.CboxMateria.FormattingEnabled = true;
            this.CboxMateria.Location = new System.Drawing.Point(659, 45);
            this.CboxMateria.Name = "CboxMateria";
            this.CboxMateria.Size = new System.Drawing.Size(121, 24);
            this.CboxMateria.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione la materia:";
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(333, 42);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(117, 26);
            this.BtnListar.TabIndex = 7;
            this.BtnListar.Text = "Listar curso";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(1279, 41);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(117, 30);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar notas";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // FrmRegistrarNotas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1579, 945);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboxMateria);
            this.Controls.Add(this.BtnSubirNotas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CboxGrado);
            this.Name = "FrmRegistrarNotas";
            this.Text = "FrmRegistrarNotas";
            this.Load += new System.EventHandler(this.FrmRegistrarNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboxGrado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSubirNotas;
        private System.Windows.Forms.ComboBox CboxMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnModificar;
    }
}