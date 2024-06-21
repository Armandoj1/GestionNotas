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
            this.components = new System.ComponentModel.Container();
            this.CboxGrado = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSubirNotas = new System.Windows.Forms.Button();
            this.CboxMateria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CboxPeriodo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnListado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.CboxMateria.Location = new System.Drawing.Point(476, 44);
            this.CboxMateria.Name = "CboxMateria";
            this.CboxMateria.Size = new System.Drawing.Size(121, 24);
            this.CboxMateria.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione la materia:";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CboxPeriodo
            // 
            this.CboxPeriodo.FormattingEnabled = true;
            this.CboxPeriodo.Location = new System.Drawing.Point(689, 45);
            this.CboxPeriodo.Name = "CboxPeriodo";
            this.CboxPeriodo.Size = new System.Drawing.Size(68, 24);
            this.CboxPeriodo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Periodo:";
            // 
            // BtnListado
            // 
            this.BtnListado.Location = new System.Drawing.Point(839, 42);
            this.BtnListado.Name = "BtnListado";
            this.BtnListado.Size = new System.Drawing.Size(161, 30);
            this.BtnListado.TabIndex = 13;
            this.BtnListado.Text = "Listar";
            this.BtnListado.UseVisualStyleBackColor = true;
            this.BtnListado.Click += new System.EventHandler(this.BtnListado_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1402, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRegistrarNotas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1579, 945);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnListado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboxPeriodo);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboxMateria);
            this.Controls.Add(this.BtnSubirNotas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CboxGrado);
            this.Name = "FrmRegistrarNotas";
            this.Text = "FrmRegistrarNotas";
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
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox CboxPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnListado;
        private System.Windows.Forms.Button button1;
    }
}