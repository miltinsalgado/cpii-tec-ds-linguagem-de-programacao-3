
namespace WinFormsApp3
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
            this.numPessoas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkOpcaoChique = new System.Windows.Forms.CheckBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkOpcaoSaudavel = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.texto_Escrita = new System.Windows.Forms.TextBox();
            this.txtCusto2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numPessoas2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDecoChique = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPessoas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPessoas2)).BeginInit();
            this.SuspendLayout();
            // 
            // numPessoas
            // 
            this.numPessoas.Location = new System.Drawing.Point(4, 32);
            this.numPessoas.Margin = new System.Windows.Forms.Padding(2);
            this.numPessoas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPessoas.Name = "numPessoas";
            this.numPessoas.Size = new System.Drawing.Size(144, 27);
            this.numPessoas.TabIndex = 0;
            this.numPessoas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPessoas.ValueChanged += new System.EventHandler(this.numPessoas_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Pessoas";
            // 
            // chkOpcaoChique
            // 
            this.chkOpcaoChique.AutoSize = true;
            this.chkOpcaoChique.Location = new System.Drawing.Point(4, 61);
            this.chkOpcaoChique.Margin = new System.Windows.Forms.Padding(2);
            this.chkOpcaoChique.Name = "chkOpcaoChique";
            this.chkOpcaoChique.Size = new System.Drawing.Size(125, 24);
            this.chkOpcaoChique.TabIndex = 2;
            this.chkOpcaoChique.Text = "Opção Chique";
            this.chkOpcaoChique.UseVisualStyleBackColor = true;
            this.chkOpcaoChique.CheckedChanged += new System.EventHandler(this.chkOpcaoChique_CheckedChanged);
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(55, 117);
            this.txtCusto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.ReadOnly = true;
            this.txtCusto.Size = new System.Drawing.Size(94, 27);
            this.txtCusto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Custo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 208);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCusto);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numPessoas);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chkOpcaoSaudavel);
            this.tabPage1.Controls.Add(this.chkOpcaoChique);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(277, 175);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jantar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkOpcaoSaudavel
            // 
            this.chkOpcaoSaudavel.AutoSize = true;
            this.chkOpcaoSaudavel.Location = new System.Drawing.Point(4, 89);
            this.chkOpcaoSaudavel.Margin = new System.Windows.Forms.Padding(2);
            this.chkOpcaoSaudavel.Name = "chkOpcaoSaudavel";
            this.chkOpcaoSaudavel.Size = new System.Drawing.Size(139, 24);
            this.chkOpcaoSaudavel.TabIndex = 3;
            this.chkOpcaoSaudavel.Text = "Opção Saudável";
            this.chkOpcaoSaudavel.UseVisualStyleBackColor = true;
            this.chkOpcaoSaudavel.CheckedChanged += new System.EventHandler(this.chkOpcaoSaudavel_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.texto_Escrita);
            this.tabPage2.Controls.Add(this.txtCusto2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.numPessoas2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.chkDecoChique);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(277, 175);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aniversário";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Escrita no Bolo";
            // 
            // texto_Escrita
            // 
            this.texto_Escrita.Location = new System.Drawing.Point(5, 111);
            this.texto_Escrita.Name = "texto_Escrita";
            this.texto_Escrita.Size = new System.Drawing.Size(125, 27);
            this.texto_Escrita.TabIndex = 12;
            this.texto_Escrita.TextChanged += new System.EventHandler(this.texto_Escrita_TextChanged);
            // 
            // txtCusto2
            // 
            this.txtCusto2.Location = new System.Drawing.Point(55, 143);
            this.txtCusto2.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusto2.Name = "txtCusto2";
            this.txtCusto2.ReadOnly = true;
            this.txtCusto2.Size = new System.Drawing.Size(94, 27);
            this.txtCusto2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Custo";
            // 
            // numPessoas2
            // 
            this.numPessoas2.Location = new System.Drawing.Point(4, 32);
            this.numPessoas2.Margin = new System.Windows.Forms.Padding(2);
            this.numPessoas2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPessoas2.Name = "numPessoas2";
            this.numPessoas2.Size = new System.Drawing.Size(144, 27);
            this.numPessoas2.TabIndex = 6;
            this.numPessoas2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPessoas2.ValueChanged += new System.EventHandler(this.numPessoas2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número de Pessoas";
            // 
            // chkDecoChique
            // 
            this.chkDecoChique.AutoSize = true;
            this.chkDecoChique.Location = new System.Drawing.Point(4, 61);
            this.chkDecoChique.Margin = new System.Windows.Forms.Padding(2);
            this.chkDecoChique.Name = "chkDecoChique";
            this.chkDecoChique.Size = new System.Drawing.Size(153, 24);
            this.chkDecoChique.TabIndex = 8;
            this.chkDecoChique.Text = "Decoração Chique";
            this.chkDecoChique.UseVisualStyleBackColor = true;
            this.chkDecoChique.CheckedChanged += new System.EventHandler(this.chkDecoChique_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 229);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPessoas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPessoas2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPessoas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkOpcaoChique;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCusto2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPessoas2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkDecoChique;
        private System.Windows.Forms.CheckBox chkOpcaoSaudavel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texto_Escrita;
    }
}

