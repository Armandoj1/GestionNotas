namespace PRESENTACION
{
    partial class Frm_EstudiantesGrados
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TxtCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtGradoID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modificar grado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Vincular grado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar grado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TxtCC
            // 
            this.TxtCC.Location = new System.Drawing.Point(173, 11);
            this.TxtCC.Name = "TxtCC";
            this.TxtCC.Size = new System.Drawing.Size(191, 22);
            this.TxtCC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificación alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID del grado:";
            // 
            // TxtGradoID
            // 
            this.TxtGradoID.Location = new System.Drawing.Point(173, 38);
            this.TxtGradoID.Name = "TxtGradoID";
            this.TxtGradoID.Size = new System.Drawing.Size(70, 22);
            this.TxtGradoID.TabIndex = 5;
            // 
            // Frm_EstudiantesGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 143);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtGradoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCC);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Frm_EstudiantesGrados";
            this.Text = "Frm_EstudiantesGrados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TxtCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtGradoID;
    }
}