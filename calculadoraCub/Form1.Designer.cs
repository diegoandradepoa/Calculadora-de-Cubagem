namespace calculadoraCub
{
    partial class calculCubagem
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblResultadoMedidas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btResultMedidas = new System.Windows.Forms.Button();
            this.txtCoefCubagem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResultadoFinal = new System.Windows.Forms.Label();
            this.btCubagem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 - Insira as medidas em Metros";
            // 
            // txtComprimento
            // 
            this.txtComprimento.BackColor = System.Drawing.SystemColors.Info;
            this.txtComprimento.Location = new System.Drawing.Point(32, 71);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(75, 20);
            this.txtComprimento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comprimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Largura";
            // 
            // txtLargura
            // 
            this.txtLargura.BackColor = System.Drawing.SystemColors.Info;
            this.txtLargura.Location = new System.Drawing.Point(132, 71);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(75, 20);
            this.txtLargura.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.Info;
            this.txtAltura.Location = new System.Drawing.Point(229, 71);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(75, 20);
            this.txtAltura.TabIndex = 6;
            // 
            // lblResultadoMedidas
            // 
            this.lblResultadoMedidas.AutoSize = true;
            this.lblResultadoMedidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoMedidas.Location = new System.Drawing.Point(133, 116);
            this.lblResultadoMedidas.Name = "lblResultadoMedidas";
            this.lblResultadoMedidas.Size = new System.Drawing.Size(0, 31);
            this.lblResultadoMedidas.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "2 - Insira o coeficiente de cubagem";
            // 
            // btResultMedidas
            // 
            this.btResultMedidas.Location = new System.Drawing.Point(351, 71);
            this.btResultMedidas.Name = "btResultMedidas";
            this.btResultMedidas.Size = new System.Drawing.Size(133, 20);
            this.btResultMedidas.TabIndex = 9;
            this.btResultMedidas.Text = "Gerar Medidas";
            this.btResultMedidas.UseVisualStyleBackColor = true;
            this.btResultMedidas.Click += new System.EventHandler(this.btResultMedidas_Click);
            // 
            // txtCoefCubagem
            // 
            this.txtCoefCubagem.BackColor = System.Drawing.SystemColors.Info;
            this.txtCoefCubagem.Location = new System.Drawing.Point(32, 206);
            this.txtCoefCubagem.Name = "txtCoefCubagem";
            this.txtCoefCubagem.Size = new System.Drawing.Size(75, 20);
            this.txtCoefCubagem.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "3 - Cubagem gerada";
            // 
            // lblResultadoFinal
            // 
            this.lblResultadoFinal.AutoSize = true;
            this.lblResultadoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoFinal.Location = new System.Drawing.Point(36, 275);
            this.lblResultadoFinal.Name = "lblResultadoFinal";
            this.lblResultadoFinal.Size = new System.Drawing.Size(0, 31);
            this.lblResultadoFinal.TabIndex = 12;
            // 
            // btCubagem
            // 
            this.btCubagem.Location = new System.Drawing.Point(194, 206);
            this.btCubagem.Name = "btCubagem";
            this.btCubagem.Size = new System.Drawing.Size(139, 23);
            this.btCubagem.TabIndex = 13;
            this.btCubagem.Text = "Gerar cubagem";
            this.btCubagem.UseVisualStyleBackColor = true;
            this.btCubagem.Click += new System.EventHandler(this.btCubagem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Resultado:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // calculCubagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 335);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btCubagem);
            this.Controls.Add(this.lblResultadoFinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCoefCubagem);
            this.Controls.Add(this.btResultMedidas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblResultadoMedidas);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComprimento);
            this.Controls.Add(this.label1);
            this.Name = "calculCubagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Cubagem v1.0";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.calculCubagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblResultadoMedidas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btResultMedidas;
        private System.Windows.Forms.TextBox txtCoefCubagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResultadoFinal;
        private System.Windows.Forms.Button btCubagem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

