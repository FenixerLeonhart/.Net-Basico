namespace FacturacionProductos
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
            this.listaBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPantalon = new System.Windows.Forms.Button();
            this.btnCamisa = new System.Windows.Forms.Button();
            this.btnZapatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.precioTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaBox
            // 
            this.listaBox.FormattingEnabled = true;
            this.listaBox.ItemHeight = 15;
            this.listaBox.Location = new System.Drawing.Point(12, 12);
            this.listaBox.Name = "listaBox";
            this.listaBox.Size = new System.Drawing.Size(139, 229);
            this.listaBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos Disponibles:";
            // 
            // btnPantalon
            // 
            this.btnPantalon.Location = new System.Drawing.Point(176, 39);
            this.btnPantalon.Name = "btnPantalon";
            this.btnPantalon.Size = new System.Drawing.Size(125, 23);
            this.btnPantalon.TabIndex = 2;
            this.btnPantalon.Text = "Pantalon";
            this.btnPantalon.UseVisualStyleBackColor = true;
            this.btnPantalon.Click += new System.EventHandler(this.btnPantalon_Click);
            // 
            // btnCamisa
            // 
            this.btnCamisa.Location = new System.Drawing.Point(176, 68);
            this.btnCamisa.Name = "btnCamisa";
            this.btnCamisa.Size = new System.Drawing.Size(125, 23);
            this.btnCamisa.TabIndex = 3;
            this.btnCamisa.Text = "Camisa";
            this.btnCamisa.UseVisualStyleBackColor = true;
            this.btnCamisa.Click += new System.EventHandler(this.btnCamisa_Click);
            // 
            // btnZapatos
            // 
            this.btnZapatos.Location = new System.Drawing.Point(176, 97);
            this.btnZapatos.Name = "btnZapatos";
            this.btnZapatos.Size = new System.Drawing.Size(125, 23);
            this.btnZapatos.TabIndex = 4;
            this.btnZapatos.Text = "Zapatos";
            this.btnZapatos.UseVisualStyleBackColor = true;
            this.btnZapatos.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(176, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio Total de Compra: ";
            // 
            // precioTotal
            // 
            this.precioTotal.AutoSize = true;
            this.precioTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.precioTotal.Location = new System.Drawing.Point(406, 214);
            this.precioTotal.Name = "precioTotal";
            this.precioTotal.Size = new System.Drawing.Size(34, 28);
            this.precioTotal.TabIndex = 6;
            this.precioTotal.Text = "0$";
            this.precioTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Agregar Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(176, 165);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(111, 23);
            this.txtDescuento.TabIndex = 8;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Snow;
            this.btnValidar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnValidar.Location = new System.Drawing.Point(311, 164);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(0);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 9;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 253);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precioTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZapatos);
            this.Controls.Add(this.btnCamisa);
            this.Controls.Add(this.btnPantalon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listaBox;
        private Label label1;
        private Button btnPantalon;
        private Button btnCamisa;
        private Button btnZapatos;
        private Label label2;
        private Label precioTotal;
        private Label label4;
        private TextBox txtDescuento;
        private Button btnValidar;
    }
}