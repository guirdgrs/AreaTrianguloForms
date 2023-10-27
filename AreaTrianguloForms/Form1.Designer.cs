namespace AreaTrianguloForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbNum1
            // 
            this.txbNum1.Location = new System.Drawing.Point(85, 74);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(100, 20);
            this.txbNum1.TabIndex = 0;
            // 
            // txbNum2
            // 
            this.txbNum2.Location = new System.Drawing.Point(85, 100);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(100, 20);
            this.txbNum2.TabIndex = 1;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(41, 77);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(31, 13);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "Base";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(41, 107);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(34, 13);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "Altura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(59, 153);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(155, 24);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(82, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(107, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Preencha os campos";
            // 
            // txbResultado
            // 
            this.txbResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbResultado.Enabled = false;
            this.txbResultado.Location = new System.Drawing.Point(85, 215);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(100, 13);
            this.txbResultado.TabIndex = 6;
            this.txbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 277);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txbNum2);
            this.Controls.Add(this.txbNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área do Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNum1;
        private System.Windows.Forms.TextBox txbNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txbResultado;
    }
}

