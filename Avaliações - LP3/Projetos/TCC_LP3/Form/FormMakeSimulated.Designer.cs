
namespace TCC_LP3.Forms
{
    partial class FormMakeSimulated
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
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabMatter = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMatter = new System.Windows.Forms.ComboBox();
            this.tabSimulated = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMatter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.richTxtBoxUtterance = new System.Windows.Forms.RichTextBox();
            this.tabPage.SuspendLayout();
            this.tabMatter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSimulated.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabMatter);
            this.tabPage.Controls.Add(this.tabSimulated);
            this.tabPage.Location = new System.Drawing.Point(-7, -22);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(811, 478);
            this.tabPage.TabIndex = 0;
            // 
            // tabMatter
            // 
            this.tabMatter.Controls.Add(this.groupBox2);
            this.tabMatter.Location = new System.Drawing.Point(4, 22);
            this.tabMatter.Name = "tabMatter";
            this.tabMatter.Padding = new System.Windows.Forms.Padding(3);
            this.tabMatter.Size = new System.Drawing.Size(803, 452);
            this.tabMatter.TabIndex = 0;
            this.tabMatter.Text = "tabPage1";
            this.tabMatter.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxMatter);
            this.groupBox2.Location = new System.Drawing.Point(241, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(81, 149);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 33);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Começar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Escolha uma das matérias \r\nabaixo para começar o \r\nsimulado:\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxMatter
            // 
            this.comboBoxMatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatter.FormattingEnabled = true;
            this.comboBoxMatter.Location = new System.Drawing.Point(45, 106);
            this.comboBoxMatter.Name = "comboBoxMatter";
            this.comboBoxMatter.Size = new System.Drawing.Size(203, 21);
            this.comboBoxMatter.TabIndex = 0;
            // 
            // tabSimulated
            // 
            this.tabSimulated.Controls.Add(this.label6);
            this.tabSimulated.Controls.Add(this.lblTime);
            this.tabSimulated.Controls.Add(this.lblMatter);
            this.tabSimulated.Controls.Add(this.label5);
            this.tabSimulated.Controls.Add(this.label4);
            this.tabSimulated.Controls.Add(this.lblPercent);
            this.tabSimulated.Controls.Add(this.progressBar);
            this.tabSimulated.Controls.Add(this.btnNextQuestion);
            this.tabSimulated.Controls.Add(this.btnAnswer);
            this.tabSimulated.Controls.Add(this.label2);
            this.tabSimulated.Controls.Add(this.label1);
            this.tabSimulated.Controls.Add(this.groupBox1);
            this.tabSimulated.Controls.Add(this.richTxtBoxSolution);
            this.tabSimulated.Controls.Add(this.richTxtBoxUtterance);
            this.tabSimulated.Location = new System.Drawing.Point(4, 22);
            this.tabSimulated.Name = "tabSimulated";
            this.tabSimulated.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulated.Size = new System.Drawing.Size(803, 452);
            this.tabSimulated.TabIndex = 1;
            this.tabSimulated.Text = "tabPage2";
            this.tabSimulated.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Tempo:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(402, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 54;
            // 
            // lblMatter
            // 
            this.lblMatter.AutoSize = true;
            this.lblMatter.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatter.Location = new System.Drawing.Point(90, 16);
            this.lblMatter.Name = "lblMatter";
            this.lblMatter.Size = new System.Drawing.Size(0, 13);
            this.lblMatter.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Matéria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "de acerto";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(508, 398);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(25, 13);
            this.lblPercent.TabIndex = 50;
            this.lblPercent.Text = "0%";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(505, 414);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(285, 23);
            this.progressBar.TabIndex = 49;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQuestion.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(651, 317);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(140, 56);
            this.btnNextQuestion.TabIndex = 48;
            this.btnNextQuestion.Text = "Pular Questão";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            // 
            // btnAnswer
            // 
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(505, 317);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(140, 56);
            this.btnAnswer.TabIndex = 47;
            this.btnAnswer.Text = "Responder Questão";
            this.btnAnswer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Solução:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Enunciado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioE);
            this.groupBox1.Controls.Add(this.radioD);
            this.groupBox1.Controls.Add(this.radioC);
            this.groupBox1.Controls.Add(this.radioB);
            this.groupBox1.Controls.Add(this.radioA);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(505, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 254);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternativas";
            // 
            // radioE
            // 
            this.radioE.AutoSize = true;
            this.radioE.Location = new System.Drawing.Point(6, 207);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(30, 15);
            this.radioE.TabIndex = 4;
            this.radioE.TabStop = true;
            this.radioE.Text = "E";
            this.radioE.UseVisualStyleBackColor = true;
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Location = new System.Drawing.Point(6, 162);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(30, 15);
            this.radioD.TabIndex = 3;
            this.radioD.TabStop = true;
            this.radioD.Text = "D";
            this.radioD.UseVisualStyleBackColor = true;
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(6, 122);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(30, 15);
            this.radioC.TabIndex = 2;
            this.radioC.TabStop = true;
            this.radioC.Text = "C";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Location = new System.Drawing.Point(6, 79);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(30, 15);
            this.radioB.TabIndex = 1;
            this.radioB.TabStop = true;
            this.radioB.Text = "B";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Location = new System.Drawing.Point(6, 33);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(30, 15);
            this.radioA.TabIndex = 0;
            this.radioA.TabStop = true;
            this.radioA.Text = "A";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // richTxtBoxSolution
            // 
            this.richTxtBoxSolution.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxSolution.Location = new System.Drawing.Point(14, 294);
            this.richTxtBoxSolution.Name = "richTxtBoxSolution";
            this.richTxtBoxSolution.ReadOnly = true;
            this.richTxtBoxSolution.Size = new System.Drawing.Size(485, 143);
            this.richTxtBoxSolution.TabIndex = 43;
            this.richTxtBoxSolution.Text = "";
            // 
            // richTxtBoxUtterance
            // 
            this.richTxtBoxUtterance.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxUtterance.Location = new System.Drawing.Point(14, 57);
            this.richTxtBoxUtterance.Name = "richTxtBoxUtterance";
            this.richTxtBoxUtterance.ReadOnly = true;
            this.richTxtBoxUtterance.Size = new System.Drawing.Size(485, 206);
            this.richTxtBoxUtterance.TabIndex = 42;
            this.richTxtBoxUtterance.Text = "";
            // 
            // FormMakeSimulated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMakeSimulated";
            this.Text = "FormMakeSimulated";
            this.tabPage.ResumeLayout(false);
            this.tabMatter.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSimulated.ResumeLayout(false);
            this.tabSimulated.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabMatter;
        private System.Windows.Forms.TabPage tabSimulated;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMatter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.RichTextBox richTxtBoxUtterance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMatter;
    }
}