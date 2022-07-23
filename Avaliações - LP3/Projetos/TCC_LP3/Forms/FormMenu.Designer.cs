
namespace TCC_LP3.Forms
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManageQuestions = new System.Windows.Forms.Button();
            this.btnSeeHistory = new System.Windows.Forms.Button();
            this.btnMenuUser = new System.Windows.Forms.Button();
            this.btnMakeSimulated = new System.Windows.Forms.Button();
            this.btnAnswerQuestions = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.btnManageQuestions);
            this.panel1.Controls.Add(this.btnSeeHistory);
            this.panel1.Controls.Add(this.btnMenuUser);
            this.panel1.Controls.Add(this.btnMakeSimulated);
            this.panel1.Controls.Add(this.btnAnswerQuestions);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 654);
            this.panel1.TabIndex = 0;
            // 
            // btnManageQuestions
            // 
            this.btnManageQuestions.BackColor = System.Drawing.Color.Gold;
            this.btnManageQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageQuestions.Enabled = false;
            this.btnManageQuestions.FlatAppearance.BorderSize = 0;
            this.btnManageQuestions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnManageQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageQuestions.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageQuestions.ForeColor = System.Drawing.SystemColors.Window;
            this.btnManageQuestions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageQuestions.Location = new System.Drawing.Point(0, 442);
            this.btnManageQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageQuestions.Name = "btnManageQuestions";
            this.btnManageQuestions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnManageQuestions.Size = new System.Drawing.Size(248, 86);
            this.btnManageQuestions.TabIndex = 10;
            this.btnManageQuestions.Text = "Gerenciar Questôes";
            this.btnManageQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageQuestions.UseVisualStyleBackColor = false;
            this.btnManageQuestions.Click += new System.EventHandler(this.btnManageQuestions_Click);
            // 
            // btnSeeHistory
            // 
            this.btnSeeHistory.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSeeHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeeHistory.FlatAppearance.BorderSize = 0;
            this.btnSeeHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnSeeHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeHistory.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeHistory.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSeeHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeHistory.Location = new System.Drawing.Point(0, 356);
            this.btnSeeHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeeHistory.Name = "btnSeeHistory";
            this.btnSeeHistory.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSeeHistory.Size = new System.Drawing.Size(248, 86);
            this.btnSeeHistory.TabIndex = 9;
            this.btnSeeHistory.Text = "Ver Histórico";
            this.btnSeeHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeeHistory.UseVisualStyleBackColor = false;
            this.btnSeeHistory.Click += new System.EventHandler(this.btnSeeHistory_Click);
            // 
            // btnMenuUser
            // 
            this.btnMenuUser.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMenuUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuUser.FlatAppearance.BorderSize = 0;
            this.btnMenuUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnMenuUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUser.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUser.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMenuUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUser.Location = new System.Drawing.Point(0, 267);
            this.btnMenuUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuUser.Name = "btnMenuUser";
            this.btnMenuUser.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnMenuUser.Size = new System.Drawing.Size(248, 89);
            this.btnMenuUser.TabIndex = 7;
            this.btnMenuUser.Text = "Menu Usuário";
            this.btnMenuUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuUser.UseVisualStyleBackColor = false;
            this.btnMenuUser.Click += new System.EventHandler(this.btnMenuUser_Click);
            // 
            // btnMakeSimulated
            // 
            this.btnMakeSimulated.BackColor = System.Drawing.Color.Purple;
            this.btnMakeSimulated.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeSimulated.FlatAppearance.BorderSize = 0;
            this.btnMakeSimulated.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnMakeSimulated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeSimulated.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeSimulated.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMakeSimulated.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakeSimulated.Location = new System.Drawing.Point(0, 180);
            this.btnMakeSimulated.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeSimulated.Name = "btnMakeSimulated";
            this.btnMakeSimulated.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnMakeSimulated.Size = new System.Drawing.Size(248, 87);
            this.btnMakeSimulated.TabIndex = 5;
            this.btnMakeSimulated.Text = "Fazer Simulado";
            this.btnMakeSimulated.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMakeSimulated.UseVisualStyleBackColor = false;
            this.btnMakeSimulated.Click += new System.EventHandler(this.btnMakeSimulated_Click);
            // 
            // btnAnswerQuestions
            // 
            this.btnAnswerQuestions.BackColor = System.Drawing.Color.Red;
            this.btnAnswerQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnswerQuestions.FlatAppearance.BorderSize = 0;
            this.btnAnswerQuestions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnAnswerQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerQuestions.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerQuestions.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAnswerQuestions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnswerQuestions.Location = new System.Drawing.Point(0, 96);
            this.btnAnswerQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnswerQuestions.Name = "btnAnswerQuestions";
            this.btnAnswerQuestions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAnswerQuestions.Size = new System.Drawing.Size(248, 84);
            this.btnAnswerQuestions.TabIndex = 3;
            this.btnAnswerQuestions.Text = "Responder Questões";
            this.btnAnswerQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnswerQuestions.UseVisualStyleBackColor = false;
            this.btnAnswerQuestions.Click += new System.EventHandler(this.btnAnswerQuestions_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 96);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TCC_LP3.Properties.Resources.home;
            this.pictureBox5.Location = new System.Drawing.Point(13, 7);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(117, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(248, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1263, 80);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(397, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(374, 30);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "SISTEMA DE QUESTÕES";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1095, 11);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 58);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1175, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 58);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackgroundImage = global::TCC_LP3.Properties.Resources.old_pc_background;
            this.panelDesktopPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktopPane.Controls.Add(this.label2);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(248, 80);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1263, 574);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(603, 66);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seja bem vindo(a) ao \r\nmenu do sistema de questões!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 654);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnswerQuestions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnSeeHistory;
        private System.Windows.Forms.Button btnMenuUser;
        private System.Windows.Forms.Button btnMakeSimulated;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnManageQuestions;
        private System.Windows.Forms.Label label2;
    }
}