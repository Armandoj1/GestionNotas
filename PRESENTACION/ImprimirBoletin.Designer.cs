namespace PRESENTACION
{
    partial class ImprimirBoletin
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEsEstudiante = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.BtnBoletinCorreo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 871);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Imprimir boletin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1555, 773);
            this.dataGridView1.TabIndex = 13;
            // 
            // TxtCC
            // 
            this.TxtCC.Location = new System.Drawing.Point(12, 40);
            this.TxtCC.Name = "TxtCC";
            this.TxtCC.Size = new System.Drawing.Size(169, 22);
            this.TxtCC.TabIndex = 14;
            this.TxtCC.TextChanged += new System.EventHandler(this.TxtCC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cédula estudiante:";
            // 
            // LblEsEstudiante
            // 
            this.LblEsEstudiante.AutoSize = true;
            this.LblEsEstudiante.Location = new System.Drawing.Point(872, 46);
            this.LblEsEstudiante.Name = "LblEsEstudiante";
            this.LblEsEstudiante.Size = new System.Drawing.Size(0, 16);
            this.LblEsEstudiante.TabIndex = 16;
            this.LblEsEstudiante.Visible = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(1176, 31);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 22);
            this.txtCorreo.TabIndex = 17;
            this.txtCorreo.Visible = false;
            // 
            // BtnBoletinCorreo
            // 
            this.BtnBoletinCorreo.Location = new System.Drawing.Point(196, 871);
            this.BtnBoletinCorreo.Name = "BtnBoletinCorreo";
            this.BtnBoletinCorreo.Size = new System.Drawing.Size(175, 33);
            this.BtnBoletinCorreo.TabIndex = 18;
            this.BtnBoletinCorreo.Text = "Enviar boletín al correo";
            this.BtnBoletinCorreo.UseVisualStyleBackColor = true;
            this.BtnBoletinCorreo.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImprimirBoletin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1579, 945);
            this.Controls.Add(this.BtnBoletinCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.LblEsEstudiante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ImprimirBoletin";
            this.Text = "ImprimirBoletin";
            this.Load += new System.EventHandler(this.ImprimirBoletin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEsEstudiante;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button BtnBoletinCorreo;
    }
}