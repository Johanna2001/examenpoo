namespace Semana03
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboproducto = new System.Windows.Forms.ComboBox();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.txtCan = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.chkDes = new System.Windows.Forms.CheckBox();
            this.txtTD = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subtotal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "IGV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descuento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total de Descuento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total";
            // 
            // cboproducto
            // 
            this.cboproducto.FormattingEnabled = true;
            this.cboproducto.Location = new System.Drawing.Point(124, 25);
            this.cboproducto.Name = "cboproducto";
            this.cboproducto.Size = new System.Drawing.Size(121, 21);
            this.cboproducto.TabIndex = 9;
            // 
            // txtpre
            // 
            this.txtpre.Location = new System.Drawing.Point(124, 60);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(100, 20);
            this.txtpre.TabIndex = 10;
            // 
            // txtCan
            // 
            this.txtCan.Location = new System.Drawing.Point(124, 97);
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(100, 20);
            this.txtCan.TabIndex = 11;
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(124, 128);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(100, 20);
            this.txtSub.TabIndex = 12;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(124, 174);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(61, 17);
            this.rbF.TabIndex = 13;
            this.rbF.TabStop = true;
            this.rbF.Text = "Factura";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(216, 174);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(101, 17);
            this.rbB.TabIndex = 14;
            this.rbB.TabStop = true;
            this.rbB.Text = "Boleta de Venta";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(124, 211);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(100, 20);
            this.txtIGV.TabIndex = 15;
            // 
            // chkDes
            // 
            this.chkDes.AutoSize = true;
            this.chkDes.Location = new System.Drawing.Point(124, 249);
            this.chkDes.Name = "chkDes";
            this.chkDes.Size = new System.Drawing.Size(35, 17);
            this.chkDes.TabIndex = 16;
            this.chkDes.Text = "Si";
            this.chkDes.UseVisualStyleBackColor = true;
            // 
            // txtTD
            // 
            this.txtTD.Location = new System.Drawing.Point(124, 283);
            this.txtTD.Name = "txtTD";
            this.txtTD.Size = new System.Drawing.Size(100, 20);
            this.txtTD.TabIndex = 17;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(124, 318);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(270, 25);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(270, 49);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 20;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTD);
            this.Controls.Add(this.chkDes);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbF);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtCan);
            this.Controls.Add(this.txtpre);
            this.Controls.Add(this.cboproducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboproducto;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.TextBox txtCan;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.CheckBox chkDes;
        private System.Windows.Forms.TextBox txtTD;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button button1;
    }
}

