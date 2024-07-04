namespace PRESENTACION
{
    partial class FrmBoletines
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
            this.TxtGrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboxMateria = new System.Windows.Forms.ComboBox();
            this.CboxGrado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(1555, 773);
            this.dataGridView1.TabIndex = 12;
            // 
            // TxtGrado
            // 
            this.TxtGrado.Location = new System.Drawing.Point(6, 46);
            this.TxtGrado.Name = "TxtGrado";
            this.TxtGrado.Size = new System.Drawing.Size(173, 22);
            this.TxtGrado.TabIndex = 14;
            this.TxtGrado.TextChanged += new System.EventHandler(this.TxtGrado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Escriba el grado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Escriba la cédula:";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(257, 46);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(170, 22);
            this.TxtCedula.TabIndex = 17;
            this.TxtCedula.TextChanged += new System.EventHandler(this.TxtCedula_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Escriba la materia: ";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Location = new System.Drawing.Point(522, 46);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(163, 22);
            this.TxtMateria.TabIndex = 20;
            this.TxtMateria.TextChanged += new System.EventHandler(this.TxtMateria_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1585, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 22);
            this.button2.TabIndex = 19;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtGrado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMateria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 84);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrados manual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CboxMateria);
            this.groupBox2.Controls.Add(this.CboxGrado);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(805, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 84);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrados automáticos";
            // 
            // CboxMateria
            // 
            this.CboxMateria.FormattingEnabled = true;
            this.CboxMateria.Location = new System.Drawing.Point(267, 49);
            this.CboxMateria.Name = "CboxMateria";
            this.CboxMateria.Size = new System.Drawing.Size(154, 24);
            this.CboxMateria.TabIndex = 25;
            // 
            // CboxGrado
            // 
            this.CboxGrado.FormattingEnabled = true;
            this.CboxGrado.Location = new System.Drawing.Point(6, 46);
            this.CboxGrado.Name = "CboxGrado";
            this.CboxGrado.Size = new System.Drawing.Size(121, 24);
            this.CboxGrado.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Escriba la materia: ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 26);
            this.button3.TabIndex = 13;
            this.button3.Text = "Filtrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Escriba el grado:";
            // 
            // FrmBoletines
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1579, 945);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmBoletines";
            this.Text = "FrmBoletines";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtGrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboxMateria;
        private System.Windows.Forms.ComboBox CboxGrado;
    }
}