namespace WinFormsApp1
{
    partial class PrimerosPasos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.Label();
            this.Valor3 = new System.Windows.Forms.TextBox();
            this.Valor1 = new System.Windows.Forms.TextBox();
            this.Valor2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Snow;
            this.btnIngresar.Location = new System.Drawing.Point(112, 129);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(114, 37);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(112, 111);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(0, 15);
            this.txtResultado.TabIndex = 1;
            // 
            // Valor3
            // 
            this.Valor3.Location = new System.Drawing.Point(112, 83);
            this.Valor3.Name = "Valor3";
            this.Valor3.Size = new System.Drawing.Size(114, 23);
            this.Valor3.TabIndex = 2;
            // 
            // Valor1
            // 
            this.Valor1.Location = new System.Drawing.Point(112, 25);
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(114, 23);
            this.Valor1.TabIndex = 3;
            // 
            // Valor2
            // 
            this.Valor2.Location = new System.Drawing.Point(112, 54);
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(114, 23);
            this.Valor2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor 3:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor 2:";
            // 
            // PrimerosPasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 190);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.Valor1);
            this.Controls.Add(this.Valor3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnIngresar);
            this.Name = "PrimerosPasos";
            this.Text = "PrimerosPasos";
            this.Load += new System.EventHandler(this.PrimerosPasos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIngresar;
        private Label txtResultado;
        private TextBox Valor3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Valor1;
        private TextBox Valor2;
    }
}