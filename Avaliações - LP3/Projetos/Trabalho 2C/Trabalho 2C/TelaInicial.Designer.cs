
namespace Trabalho_2C
{
    partial class TelaInicial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnResponderQuestoes = new System.Windows.Forms.Button();
            this.btnCadQuestoes = new System.Windows.Forms.Button();
            this.pgrsBarMenu = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 30);
            this.panel1.TabIndex = 56;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMin.Location = new System.Drawing.Point(384, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(63, 30);
            this.btnMin.TabIndex = 56;
            this.btnMin.Text = "–";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFechar.Location = new System.Drawing.Point(447, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(71, 30);
            this.btnFechar.TabIndex = 42;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(313, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tela Inicial do Sistema de Questões";
            // 
            // btnResponderQuestoes
            // 
            this.btnResponderQuestoes.BackColor = System.Drawing.SystemColors.Window;
            this.btnResponderQuestoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponderQuestoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponderQuestoes.Location = new System.Drawing.Point(219, 58);
            this.btnResponderQuestoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnResponderQuestoes.Name = "btnResponderQuestoes";
            this.btnResponderQuestoes.Size = new System.Drawing.Size(284, 51);
            this.btnResponderQuestoes.TabIndex = 59;
            this.btnResponderQuestoes.Text = "Responder Questões";
            this.btnResponderQuestoes.UseVisualStyleBackColor = false;
            this.btnResponderQuestoes.Click += new System.EventHandler(this.btnResponderQuestoes_Click_1);
            // 
            // btnCadQuestoes
            // 
            this.btnCadQuestoes.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadQuestoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadQuestoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadQuestoes.Location = new System.Drawing.Point(219, 147);
            this.btnCadQuestoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadQuestoes.Name = "btnCadQuestoes";
            this.btnCadQuestoes.Size = new System.Drawing.Size(284, 51);
            this.btnCadQuestoes.TabIndex = 60;
            this.btnCadQuestoes.Text = "Cadastrar Questões";
            this.btnCadQuestoes.UseVisualStyleBackColor = false;
            this.btnCadQuestoes.Click += new System.EventHandler(this.btnCadQuestoes_Click_1);
            // 
            // pgrsBarMenu
            // 
            this.pgrsBarMenu.Location = new System.Drawing.Point(15, 228);
            this.pgrsBarMenu.Name = "pgrsBarMenu";
            this.pgrsBarMenu.Size = new System.Drawing.Size(490, 29);
            this.pgrsBarMenu.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgrsBarMenu.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 68);
            this.label1.TabIndex = 62;
            this.label1.Text = "Para cadastrar questões, \r\nclique no botão ao lado\r\ne informe um usuário \r\ne uma " +
    "senha.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 51);
            this.label2.TabIndex = 63;
            this.label2.Text = "Para responder questões \r\narmazenadas no sistema, \r\nclique no botão ao lado.";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Trabalho_2C.Properties.Resources.Background_Tela_Inicial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgrsBarMenu);
            this.Controls.Add(this.btnCadQuestoes);
            this.Controls.Add(this.btnResponderQuestoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial do Sis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnResponderQuestoes;
        private System.Windows.Forms.Button btnCadQuestoes;
        private System.Windows.Forms.ProgressBar pgrsBarMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}