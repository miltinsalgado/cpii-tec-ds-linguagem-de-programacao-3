
namespace Questão_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.numVal = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numMes = new System.Windows.Forms.NumericUpDown();
            this.numAno = new System.Windows.Forms.NumericUpDown();
            this.numDia = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtOri = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRTA = new System.Windows.Forms.RadioButton();
            this.radEF = new System.Windows.Forms.RadioButton();
            this.radAE = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxResumo = new System.Windows.Forms.ListBox();
            this.btnChecar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numArrec = new System.Windows.Forms.NumericUpDown();
            this.numViagens = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtRecibo = new System.Windows.Forms.RichTextBox();
            this.numRecibo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArrec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numViagens)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecibo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdicionar);
            this.tabPage1.Controls.Add(this.numVal);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.numMes);
            this.tabPage1.Controls.Add(this.numAno);
            this.tabPage1.Controls.Add(this.numDia);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtDest);
            this.tabPage1.Controls.Add(this.txtPass);
            this.tabPage1.Controls.Add(this.txtOri);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(481, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar Recibo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(24, 299);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(416, 66);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.Text = "Adicionar recibo";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // numVal
            // 
            this.numVal.DecimalPlaces = 2;
            this.numVal.Location = new System.Drawing.Point(150, 257);
            this.numVal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numVal.Name = "numVal";
            this.numVal.Size = new System.Drawing.Size(126, 29);
            this.numVal.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor Pago ($)";
            // 
            // numMes
            // 
            this.numMes.Location = new System.Drawing.Point(192, 209);
            this.numMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMes.Name = "numMes";
            this.numMes.Size = new System.Drawing.Size(68, 29);
            this.numMes.TabIndex = 12;
            this.numMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMes.ValueChanged += new System.EventHandler(this.numMes_ValueChanged);
            // 
            // numAno
            // 
            this.numAno.Location = new System.Drawing.Point(314, 209);
            this.numAno.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numAno.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numAno.Name = "numAno";
            this.numAno.Size = new System.Drawing.Size(126, 29);
            this.numAno.TabIndex = 11;
            this.numAno.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numAno.ValueChanged += new System.EventHandler(this.numAno_ValueChanged);
            // 
            // numDia
            // 
            this.numDia.Location = new System.Drawing.Point(71, 209);
            this.numDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDia.Name = "numDia";
            this.numDia.Size = new System.Drawing.Size(68, 29);
            this.numDia.TabIndex = 10;
            this.numDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDia.ValueChanged += new System.EventHandler(this.numDia_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mês";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dia";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(119, 99);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(320, 29);
            this.txtDest.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(119, 29);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(320, 29);
            this.txtPass.TabIndex = 5;
            // 
            // txtOri
            // 
            this.txtOri.Location = new System.Drawing.Point(119, 64);
            this.txtOri.Name = "txtOri";
            this.txtOri.Size = new System.Drawing.Size(320, 29);
            this.txtOri.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRTA);
            this.groupBox1.Controls.Add(this.radEF);
            this.groupBox1.Controls.Add(this.radAE);
            this.groupBox1.Location = new System.Drawing.Point(24, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Companhia Aérea";
            // 
            // radRTA
            // 
            this.radRTA.AutoSize = true;
            this.radRTA.Location = new System.Drawing.Point(225, 27);
            this.radRTA.Name = "radRTA";
            this.radRTA.Size = new System.Drawing.Size(164, 25);
            this.radRTA.TabIndex = 2;
            this.radRTA.TabStop = true;
            this.radRTA.Text = "Royal Tripe Airlines";
            this.radRTA.UseVisualStyleBackColor = true;
            // 
            // radEF
            // 
            this.radEF.AutoSize = true;
            this.radEF.Location = new System.Drawing.Point(126, 27);
            this.radEF.Name = "radEF";
            this.radEF.Size = new System.Drawing.Size(87, 25);
            this.radEF.TabIndex = 1;
            this.radEF.TabStop = true;
            this.radEF.Text = "Euro Fly";
            this.radEF.UseVisualStyleBackColor = true;
            // 
            // radAE
            // 
            this.radAE.AutoSize = true;
            this.radAE.Location = new System.Drawing.Point(7, 27);
            this.radAE.Name = "radAE";
            this.radAE.Size = new System.Drawing.Size(104, 25);
            this.radAE.TabIndex = 0;
            this.radAE.TabStop = true;
            this.radAE.Text = "Air Europe";
            this.radAE.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passageiro";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxResumo);
            this.tabPage2.Controls.Add(this.btnChecar);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.numArrec);
            this.tabPage2.Controls.Add(this.numViagens);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(481, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resumo por Recibo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxResumo
            // 
            this.listBoxResumo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxResumo.FormattingEnabled = true;
            this.listBoxResumo.ItemHeight = 23;
            this.listBoxResumo.Location = new System.Drawing.Point(12, 76);
            this.listBoxResumo.Name = "listBoxResumo";
            this.listBoxResumo.Size = new System.Drawing.Size(463, 303);
            this.listBoxResumo.TabIndex = 5;
            // 
            // btnChecar
            // 
            this.btnChecar.Location = new System.Drawing.Point(360, 4);
            this.btnChecar.Name = "btnChecar";
            this.btnChecar.Size = new System.Drawing.Size(115, 65);
            this.btnChecar.TabIndex = 4;
            this.btnChecar.Text = "Checar";
            this.btnChecar.UseVisualStyleBackColor = true;
            this.btnChecar.Click += new System.EventHandler(this.btnChecar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total de Viagens";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Arrecadação Total";
            // 
            // numArrec
            // 
            this.numArrec.DecimalPlaces = 2;
            this.numArrec.Enabled = false;
            this.numArrec.Location = new System.Drawing.Point(162, 41);
            this.numArrec.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numArrec.Name = "numArrec";
            this.numArrec.ReadOnly = true;
            this.numArrec.Size = new System.Drawing.Size(191, 29);
            this.numArrec.TabIndex = 1;
            // 
            // numViagens
            // 
            this.numViagens.Enabled = false;
            this.numViagens.Location = new System.Drawing.Point(162, 6);
            this.numViagens.Name = "numViagens";
            this.numViagens.ReadOnly = true;
            this.numViagens.Size = new System.Drawing.Size(191, 29);
            this.numViagens.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtRecibo);
            this.tabPage3.Controls.Add(this.numRecibo);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(481, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conferir Recibo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtRecibo
            // 
            this.txtRecibo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecibo.Location = new System.Drawing.Point(7, 64);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(468, 324);
            this.txtRecibo.TabIndex = 2;
            this.txtRecibo.Text = "";
            // 
            // numRecibo
            // 
            this.numRecibo.Location = new System.Drawing.Point(164, 19);
            this.numRecibo.Name = "numRecibo";
            this.numRecibo.Size = new System.Drawing.Size(311, 29);
            this.numRecibo.TabIndex = 1;
            this.numRecibo.ValueChanged += new System.EventHandler(this.numRecibo_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Recibo de Número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 455);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Far From Home";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArrec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numViagens)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecibo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtOri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radRTA;
        private System.Windows.Forms.RadioButton radEF;
        private System.Windows.Forms.RadioButton radAE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMes;
        private System.Windows.Forms.NumericUpDown numAno;
        private System.Windows.Forms.NumericUpDown numDia;
        private System.Windows.Forms.NumericUpDown numVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox listBoxResumo;
        private System.Windows.Forms.Button btnChecar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numArrec;
        private System.Windows.Forms.NumericUpDown numViagens;
        private System.Windows.Forms.RichTextBox txtRecibo;
        private System.Windows.Forms.NumericUpDown numRecibo;
        private System.Windows.Forms.Label label10;
    }
}

