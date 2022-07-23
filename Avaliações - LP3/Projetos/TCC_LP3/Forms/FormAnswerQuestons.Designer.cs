
namespace TCC_LP3.Forms
{
    partial class FormAnswerQuestons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnswerQuestons));
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.comboBoxMatter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabQuestions = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblMatter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioE = new System.Windows.Forms.RadioButton();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.richTxtBoxSolution = new System.Windows.Forms.RichTextBox();
            this.richTxtBoxWordings = new System.Windows.Forms.RichTextBox();
            this.tabPage.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabQuestions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabInfo);
            this.tabPage.Controls.Add(this.tabQuestions);
            this.tabPage.Location = new System.Drawing.Point(-7, -27);
            this.tabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(1275, 606);
            this.tabPage.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.Transparent;
            this.tabInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabInfo.BackgroundImage")));
            this.tabInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabInfo.Controls.Add(this.btnStart);
            this.tabInfo.Controls.Add(this.comboBoxMatter);
            this.tabInfo.Controls.Add(this.label3);
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabInfo.Size = new System.Drawing.Size(1267, 577);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "tabInfo";
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(441, 302);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(253, 41);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Começar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // comboBoxMatter
            // 
            this.comboBoxMatter.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxMatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatter.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMatter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxMatter.Location = new System.Drawing.Point(459, 260);
            this.comboBoxMatter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMatter.Name = "comboBoxMatter";
            this.comboBoxMatter.Size = new System.Drawing.Size(212, 25);
            this.comboBoxMatter.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(778, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selecione uma matéria abaixo para visualizar e responder suas questões";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabQuestions
            // 
            this.tabQuestions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabQuestions.Controls.Add(this.label6);
            this.tabQuestions.Controls.Add(this.lblDifficulty);
            this.tabQuestions.Controls.Add(this.lblMatter);
            this.tabQuestions.Controls.Add(this.label5);
            this.tabQuestions.Controls.Add(this.lblPercent);
            this.tabQuestions.Controls.Add(this.progressBar);
            this.tabQuestions.Controls.Add(this.btnNextQuestion);
            this.tabQuestions.Controls.Add(this.btnAnswer);
            this.tabQuestions.Controls.Add(this.label2);
            this.tabQuestions.Controls.Add(this.label1);
            this.tabQuestions.Controls.Add(this.groupBox1);
            this.tabQuestions.Controls.Add(this.richTxtBoxSolution);
            this.tabQuestions.Controls.Add(this.richTxtBoxWordings);
            this.tabQuestions.Location = new System.Drawing.Point(4, 25);
            this.tabQuestions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabQuestions.Name = "tabQuestions";
            this.tabQuestions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabQuestions.Size = new System.Drawing.Size(1267, 577);
            this.tabQuestions.TabIndex = 1;
            this.tabQuestions.Text = "tabQuestions";
            this.tabQuestions.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Dificuldade:";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.BackColor = System.Drawing.SystemColors.Window;
            this.lblDifficulty.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(585, 37);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(0, 17);
            this.lblDifficulty.TabIndex = 40;
            // 
            // lblMatter
            // 
            this.lblMatter.AutoSize = true;
            this.lblMatter.BackColor = System.Drawing.SystemColors.Window;
            this.lblMatter.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatter.Location = new System.Drawing.Point(117, 26);
            this.lblMatter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatter.Name = "lblMatter";
            this.lblMatter.Size = new System.Drawing.Size(0, 17);
            this.lblMatter.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Matéria:";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.SystemColors.Window;
            this.lblPercent.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(678, 506);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(151, 17);
            this.lblPercent.TabIndex = 36;
            this.lblPercent.Text = "0% de Acertos";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Window;
            this.progressBar.Location = new System.Drawing.Point(674, 526);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(380, 28);
            this.progressBar.TabIndex = 35;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQuestion.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.ForeColor = System.Drawing.Color.Red;
            this.btnNextQuestion.Location = new System.Drawing.Point(869, 406);
            this.btnNextQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(187, 69);
            this.btnNextQuestion.TabIndex = 34;
            this.btnNextQuestion.Text = "Próxima Questão";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnswer.Enabled = false;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.ForeColor = System.Drawing.Color.Red;
            this.btnAnswer.Location = new System.Drawing.Point(674, 406);
            this.btnAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(187, 69);
            this.btnAnswer.TabIndex = 33;
            this.btnAnswer.Text = "Responder Questão";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 387);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Solução:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Enunciado:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.radioE);
            this.groupBox1.Controls.Add(this.radioD);
            this.groupBox1.Controls.Add(this.radioC);
            this.groupBox1.Controls.Add(this.radioB);
            this.groupBox1.Controls.Add(this.radioA);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(436, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(817, 322);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternativas";
            // 
            // radioE
            // 
            this.radioE.AutoSize = true;
            this.radioE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioE.Location = new System.Drawing.Point(8, 255);
            this.radioE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(38, 21);
            this.radioE.TabIndex = 4;
            this.radioE.TabStop = true;
            this.radioE.Text = "E";
            this.radioE.UseVisualStyleBackColor = true;
            this.radioE.CheckedChanged += new System.EventHandler(this.radioE_CheckedChanged);
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioD.Location = new System.Drawing.Point(8, 199);
            this.radioD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(39, 21);
            this.radioD.TabIndex = 3;
            this.radioD.TabStop = true;
            this.radioD.Text = "D";
            this.radioD.UseVisualStyleBackColor = true;
            this.radioD.CheckedChanged += new System.EventHandler(this.radioD_CheckedChanged);
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioC.Location = new System.Drawing.Point(8, 150);
            this.radioC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(38, 21);
            this.radioC.TabIndex = 2;
            this.radioC.TabStop = true;
            this.radioC.Text = "C";
            this.radioC.UseVisualStyleBackColor = true;
            this.radioC.CheckedChanged += new System.EventHandler(this.radioC_CheckedChanged);
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB.Location = new System.Drawing.Point(8, 97);
            this.radioB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(38, 21);
            this.radioB.TabIndex = 1;
            this.radioB.TabStop = true;
            this.radioB.Text = "B";
            this.radioB.UseVisualStyleBackColor = true;
            this.radioB.CheckedChanged += new System.EventHandler(this.radioB_CheckedChanged);
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioA.Location = new System.Drawing.Point(8, 41);
            this.radioA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(38, 21);
            this.radioA.TabIndex = 0;
            this.radioA.TabStop = true;
            this.radioA.Text = "A";
            this.radioA.UseVisualStyleBackColor = true;
            this.radioA.CheckedChanged += new System.EventHandler(this.radioA_CheckedChanged);
            // 
            // richTxtBoxSolution
            // 
            this.richTxtBoxSolution.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxSolution.Location = new System.Drawing.Point(19, 406);
            this.richTxtBoxSolution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTxtBoxSolution.Name = "richTxtBoxSolution";
            this.richTxtBoxSolution.ReadOnly = true;
            this.richTxtBoxSolution.Size = new System.Drawing.Size(409, 153);
            this.richTxtBoxSolution.TabIndex = 29;
            this.richTxtBoxSolution.Text = "";
            // 
            // richTxtBoxWordings
            // 
            this.richTxtBoxWordings.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxWordings.Location = new System.Drawing.Point(19, 85);
            this.richTxtBoxWordings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTxtBoxWordings.Name = "richTxtBoxWordings";
            this.richTxtBoxWordings.ReadOnly = true;
            this.richTxtBoxWordings.Size = new System.Drawing.Size(409, 293);
            this.richTxtBoxWordings.TabIndex = 28;
            this.richTxtBoxWordings.Text = "";
            // 
            // FormAnswerQuestons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 574);
            this.Controls.Add(this.tabPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAnswerQuestons";
            this.tabPage.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.tabQuestions.ResumeLayout(false);
            this.tabQuestions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabQuestions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblMatter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RichTextBox richTxtBoxSolution;
        private System.Windows.Forms.RichTextBox richTxtBoxWordings;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox comboBoxMatter;
        private System.Windows.Forms.Label label3;
    }
}