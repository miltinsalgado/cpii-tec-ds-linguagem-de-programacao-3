namespace LoginExemplo
{
    partial class ImpostoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpostoForm));
            this.cmbCodigoPacote = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMercadoria = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFrete = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeguro = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAduaneiro = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbStatusPacote = new System.Windows.Forms.ComboBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnReter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numImposto = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImposto)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCodigoPacote
            // 
            this.cmbCodigoPacote.FormattingEnabled = true;
            this.cmbCodigoPacote.Location = new System.Drawing.Point(209, 64);
            this.cmbCodigoPacote.Name = "cmbCodigoPacote";
            this.cmbCodigoPacote.Size = new System.Drawing.Size(472, 28);
            this.cmbCodigoPacote.TabIndex = 0;
            this.cmbCodigoPacote.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoPacote_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código do Pacote";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(175, 43);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(210, 26);
            this.txtCPF.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF do Importador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado de Destino";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(538, 40);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(100, 26);
            this.txtEstado.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor da Mercadoria (unidade)";
            // 
            // txtMercadoria
            // 
            this.txtMercadoria.Location = new System.Drawing.Point(253, 106);
            this.txtMercadoria.Name = "txtMercadoria";
            this.txtMercadoria.ReadOnly = true;
            this.txtMercadoria.Size = new System.Drawing.Size(132, 26);
            this.txtMercadoria.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor do Frete (pacote)";
            // 
            // txtFrete
            // 
            this.txtFrete.Location = new System.Drawing.Point(253, 138);
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.ReadOnly = true;
            this.txtFrete.Size = new System.Drawing.Size(132, 26);
            this.txtFrete.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor do Seguro (pacote)";
            // 
            // txtSeguro
            // 
            this.txtSeguro.Location = new System.Drawing.Point(253, 170);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.ReadOnly = true;
            this.txtSeguro.Size = new System.Drawing.Size(132, 26);
            this.txtSeguro.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor Aduaneiro";
            // 
            // txtAduaneiro
            // 
            this.txtAduaneiro.Location = new System.Drawing.Point(253, 202);
            this.txtAduaneiro.Name = "txtAduaneiro";
            this.txtAduaneiro.ReadOnly = true;
            this.txtAduaneiro.Size = new System.Drawing.Size(132, 26);
            this.txtAduaneiro.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(489, 106);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(149, 26);
            this.txtQuantidade.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 256);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(187, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total de Imposto a Pagar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Status do Pacote";
            // 
            // cmbStatusPacote
            // 
            this.cmbStatusPacote.FormattingEnabled = true;
            this.cmbStatusPacote.Location = new System.Drawing.Point(15, 64);
            this.cmbStatusPacote.Name = "cmbStatusPacote";
            this.cmbStatusPacote.Size = new System.Drawing.Size(130, 28);
            this.cmbStatusPacote.TabIndex = 18;
            this.cmbStatusPacote.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(22, 477);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(356, 50);
            this.btnProcessar.TabIndex = 20;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // btnReter
            // 
            this.btnReter.Location = new System.Drawing.Point(385, 477);
            this.btnReter.Name = "btnReter";
            this.btnReter.Size = new System.Drawing.Size(356, 50);
            this.btnReter.TabIndex = 21;
            this.btnReter.Text = "Reter";
            this.btnReter.UseVisualStyleBackColor = true;
            this.btnReter.Click += new System.EventHandler(this.btnReter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCodigoPacote);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbStatusPacote);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(22, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 138);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Pacote";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numImposto);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtMercadoria);
            this.groupBox2.Controls.Add(this.txtCPF);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFrete);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSeguro);
            this.groupBox2.Controls.Add(this.txtAduaneiro);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(22, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 320);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados tributários";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(445, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // numImposto
            // 
            this.numImposto.DecimalPlaces = 2;
            this.numImposto.Location = new System.Drawing.Point(253, 256);
            this.numImposto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numImposto.Name = "numImposto";
            this.numImposto.Size = new System.Drawing.Size(132, 26);
            this.numImposto.TabIndex = 19;
            // 
            // ImpostoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReter);
            this.Controls.Add(this.btnProcessar);
            this.Name = "ImpostoForm";
            this.Text = "ImpostoForm";
            this.Load += new System.EventHandler(this.ImpostoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImposto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCodigoPacote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtMercadoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtFrete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtSeguro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtAduaneiro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtQuantidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbStatusPacote;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Button btnReter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numImposto;
    }
}