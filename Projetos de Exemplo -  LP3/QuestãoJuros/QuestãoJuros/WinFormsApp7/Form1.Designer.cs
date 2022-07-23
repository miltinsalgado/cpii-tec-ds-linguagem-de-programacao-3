
namespace WinFormsApp7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbComposto = new System.Windows.Forms.RadioButton();
            this.rdbSimples = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numTempo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.numCapital = new System.Windows.Forms.NumericUpDown();
            this.numTaxa = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbComposto);
            this.groupBox1.Controls.Add(this.rdbSimples);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Juros";
            // 
            // rdbComposto
            // 
            this.rdbComposto.AutoSize = true;
            this.rdbComposto.Location = new System.Drawing.Point(209, 65);
            this.rdbComposto.Name = "rdbComposto";
            this.rdbComposto.Size = new System.Drawing.Size(122, 29);
            this.rdbComposto.TabIndex = 1;
            this.rdbComposto.TabStop = true;
            this.rdbComposto.Text = "Composto";
            this.rdbComposto.UseVisualStyleBackColor = true;
            this.rdbComposto.CheckedChanged += new System.EventHandler(this.rdbComposto_CheckedChanged);
            // 
            // rdbSimples
            // 
            this.rdbSimples.AutoSize = true;
            this.rdbSimples.Location = new System.Drawing.Point(21, 65);
            this.rdbSimples.Name = "rdbSimples";
            this.rdbSimples.Size = new System.Drawing.Size(99, 29);
            this.rdbSimples.TabIndex = 0;
            this.rdbSimples.TabStop = true;
            this.rdbSimples.Text = "Simples";
            this.rdbSimples.UseVisualStyleBackColor = true;
            this.rdbSimples.CheckedChanged += new System.EventHandler(this.rdbSimples_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capital Inicial (R$)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taxa de juros (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Meses";
            // 
            // numTempo
            // 
            this.numTempo.Location = new System.Drawing.Point(33, 283);
            this.numTempo.Name = "numTempo";
            this.numTempo.Size = new System.Drawing.Size(182, 31);
            this.numTempo.TabIndex = 6;
            this.numTempo.ValueChanged += new System.EventHandler(this.numTempo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor do Juros a ser pago";
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(33, 358);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.ReadOnly = true;
            this.txtJuros.Size = new System.Drawing.Size(325, 31);
            this.txtJuros.TabIndex = 8;
            // 
            // numCapital
            // 
            this.numCapital.DecimalPlaces = 2;
            this.numCapital.Location = new System.Drawing.Point(190, 176);
            this.numCapital.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCapital.Name = "numCapital";
            this.numCapital.Size = new System.Drawing.Size(168, 31);
            this.numCapital.TabIndex = 9;
            this.numCapital.ValueChanged += new System.EventHandler(this.numCapital_ValueChanged);
            // 
            // numTaxa
            // 
            this.numTaxa.Location = new System.Drawing.Point(190, 213);
            this.numTaxa.Name = "numTaxa";
            this.numTaxa.Size = new System.Drawing.Size(168, 31);
            this.numTaxa.TabIndex = 10;
            this.numTaxa.ValueChanged += new System.EventHandler(this.numTaxa_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tempo de aplicação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 412);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numTaxa);
            this.Controls.Add(this.numCapital);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbComposto;
        private System.Windows.Forms.RadioButton rdbSimples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.NumericUpDown numCapital;
        private System.Windows.Forms.NumericUpDown numTaxa;
        private System.Windows.Forms.Label label5;
    }
}

