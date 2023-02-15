namespace ConvertidorMonedaExtranjeraALocal
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDolarEstimado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorDBlue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorLimiteChile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorRealCHile = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERTIDOR DE MONEDA EXTRANJERA A LOCAL \r\nCON USD COMO REFERENCIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDolarEstimado
            // 
            this.txtDolarEstimado.Location = new System.Drawing.Point(12, 99);
            this.txtDolarEstimado.Name = "txtDolarEstimado";
            this.txtDolarEstimado.Size = new System.Drawing.Size(158, 23);
            this.txtDolarEstimado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ganancia en Dolares Relativa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "ValorDolarBlue";
            // 
            // txtValorDBlue
            // 
            this.txtValorDBlue.Location = new System.Drawing.Point(12, 164);
            this.txtValorDBlue.Name = "txtValorDBlue";
            this.txtValorDBlue.Size = new System.Drawing.Size(158, 23);
            this.txtValorDBlue.TabIndex = 3;
            this.txtValorDBlue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Limite Chile";
            // 
            // txtValorLimiteChile
            // 
            this.txtValorLimiteChile.Location = new System.Drawing.Point(196, 99);
            this.txtValorLimiteChile.Name = "txtValorLimiteChile";
            this.txtValorLimiteChile.Size = new System.Drawing.Size(158, 23);
            this.txtValorLimiteChile.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Real Chile";
            // 
            // txtValorRealCHile
            // 
            this.txtValorRealCHile.Location = new System.Drawing.Point(196, 164);
            this.txtValorRealCHile.Name = "txtValorRealCHile";
            this.txtValorRealCHile.Size = new System.Drawing.Size(158, 23);
            this.txtValorRealCHile.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 193);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(342, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 234);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorRealCHile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorLimiteChile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorDBlue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDolarEstimado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDolarEstimado;
        private TextBox txtValorDBlue;
        private Label label3;
        private Label label4;
        private TextBox txtValorLimiteChile;
        private Label label5;
        private TextBox txtValorRealCHile;
        private Button btnCalcular;
    }
}