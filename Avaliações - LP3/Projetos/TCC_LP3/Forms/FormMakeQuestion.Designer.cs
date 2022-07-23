
namespace TCC_LP3.Forms
{
    partial class FormMakeQuestion
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
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.comboBoxMatter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabQuestion = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxQuestions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateQuestion = new System.Windows.Forms.Button();
            this.lblMatter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegisterQuestion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTxtBoxE = new System.Windows.Forms.RichTextBox();
            this.richTxtBoxD = new System.Windows.Forms.RichTextBox();
            this.richTxtBoxC = new System.Windows.Forms.RichTextBox();
            this.richTxtBoxB = new System.Windows.Forms.RichTextBox();
            this.richTxtBoxA = new System.Windows.Forms.RichTextBox();
            this.radioE = new System.Windows.Forms.RadioButton();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.richTxtBoxSolution = new System.Windows.Forms.RichTextBox();
            this.richTxtBoxWordings = new System.Windows.Forms.RichTextBox();
            this.tabPage.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabQuestion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabInfo);
            this.tabPage.Controls.Add(this.tabQuestion);
            this.tabPage.Location = new System.Drawing.Point(-8, -28);
            this.tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(1276, 608);
            this.tabPage.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.BackgroundImage = global::TCC_LP3.Properties.Resources.questions_background;
            this.tabInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabInfo.Controls.Add(this.btnStart);
            this.tabInfo.Controls.Add(this.comboBoxMatter);
            this.tabInfo.Controls.Add(this.label3);
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tabInfo.Size = new System.Drawing.Size(1268, 579);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "tabPage";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(456, 300);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(253, 41);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Começar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // comboBoxMatter
            // 
            this.comboBoxMatter.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxMatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatter.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMatter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxMatter.Location = new System.Drawing.Point(473, 258);
            this.comboBoxMatter.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMatter.Name = "comboBoxMatter";
            this.comboBoxMatter.Size = new System.Drawing.Size(212, 25);
            this.comboBoxMatter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(195, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(833, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecione uma matéria abaixo para cadastrar, editar e/ou atualizar questões";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabQuestion
            // 
            this.tabQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabQuestion.Controls.Add(this.label4);
            this.tabQuestion.Controls.Add(this.comboBoxQuestions);
            this.tabQuestion.Controls.Add(this.label1);
            this.tabQuestion.Controls.Add(this.btnUpdateQuestion);
            this.tabQuestion.Controls.Add(this.lblMatter);
            this.tabQuestion.Controls.Add(this.label5);
            this.tabQuestion.Controls.Add(this.btnRegisterQuestion);
            this.tabQuestion.Controls.Add(this.label2);
            this.tabQuestion.Controls.Add(this.groupBox1);
            this.tabQuestion.Controls.Add(this.richTxtBoxSolution);
            this.tabQuestion.Controls.Add(this.richTxtBoxWordings);
            this.tabQuestion.Location = new System.Drawing.Point(4, 25);
            this.tabQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.tabQuestion.Name = "tabQuestion";
            this.tabQuestion.Padding = new System.Windows.Forms.Padding(4);
            this.tabQuestion.Size = new System.Drawing.Size(1268, 579);
            this.tabQuestion.TabIndex = 1;
            this.tabQuestion.Text = "tabQuestion";
            this.tabQuestion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Enunciado:";
            // 
            // comboBoxQuestions
            // 
            this.comboBoxQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuestions.FormattingEnabled = true;
            this.comboBoxQuestions.Location = new System.Drawing.Point(583, 9);
            this.comboBoxQuestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxQuestions.Name = "comboBoxQuestions";
            this.comboBoxQuestions.Size = new System.Drawing.Size(55, 24);
            this.comboBoxQuestions.TabIndex = 51;
            this.comboBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuestions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Questões:";
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.btnUpdateQuestion.Enabled = false;
            this.btnUpdateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQuestion.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateQuestion.ForeColor = System.Drawing.Color.Red;
            this.btnUpdateQuestion.Location = new System.Drawing.Point(989, 499);
            this.btnUpdateQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(263, 59);
            this.btnUpdateQuestion.TabIndex = 49;
            this.btnUpdateQuestion.Text = "Atualizar Questão";
            this.btnUpdateQuestion.UseVisualStyleBackColor = false;
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);
            // 
            // lblMatter
            // 
            this.lblMatter.AutoSize = true;
            this.lblMatter.BackColor = System.Drawing.SystemColors.Window;
            this.lblMatter.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatter.Location = new System.Drawing.Point(140, 12);
            this.lblMatter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatter.Name = "lblMatter";
            this.lblMatter.Size = new System.Drawing.Size(0, 17);
            this.lblMatter.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Matéria:";
            // 
            // btnRegisterQuestion
            // 
            this.btnRegisterQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.btnRegisterQuestion.Enabled = false;
            this.btnRegisterQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterQuestion.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterQuestion.ForeColor = System.Drawing.Color.Red;
            this.btnRegisterQuestion.Location = new System.Drawing.Point(988, 411);
            this.btnRegisterQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterQuestion.Name = "btnRegisterQuestion";
            this.btnRegisterQuestion.Size = new System.Drawing.Size(264, 59);
            this.btnRegisterQuestion.TabIndex = 43;
            this.btnRegisterQuestion.Text = "Cadastrar Questão";
            this.btnRegisterQuestion.UseVisualStyleBackColor = false;
            this.btnRegisterQuestion.Click += new System.EventHandler(this.btnRegisterQuestion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Solução:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.richTxtBoxE);
            this.groupBox1.Controls.Add(this.richTxtBoxD);
            this.groupBox1.Controls.Add(this.richTxtBoxC);
            this.groupBox1.Controls.Add(this.richTxtBoxB);
            this.groupBox1.Controls.Add(this.richTxtBoxA);
            this.groupBox1.Controls.Add(this.radioE);
            this.groupBox1.Controls.Add(this.radioD);
            this.groupBox1.Controls.Add(this.radioC);
            this.groupBox1.Controls.Add(this.radioB);
            this.groupBox1.Controls.Add(this.radioA);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(456, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(804, 322);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternativas";
            // 
            // richTxtBoxE
            // 
            this.richTxtBoxE.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxE.Location = new System.Drawing.Point(59, 254);
            this.richTxtBoxE.Margin = new System.Windows.Forms.Padding(4);
            this.richTxtBoxE.Name = "richTxtBoxE";
            this.richTxtBoxE.Size = new System.Drawing.Size(737, 51);
            this.richTxtBoxE.TabIndex = 50;
            this.richTxtBoxE.Text = "";
            this.richTxtBoxE.TextChanged += new System.EventHandler(this.richTxtBoxE_TextChanged);
            // 
            // richTxtBoxD
            // 
            this.richTxtBoxD.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxD.Location = new System.Drawing.Point(59, 198);
            this.richTxtBoxD.Margin = new System.Windows.Forms.Padding(4);
            this.richTxtBoxD.Name = "richTxtBoxD";
            this.richTxtBoxD.Size = new System.Drawing.Size(737, 51);
            this.richTxtBoxD.TabIndex = 50;
            this.richTxtBoxD.Text = "";
            this.richTxtBoxD.TextChanged += new System.EventHandler(this.richTxtBoxD_TextChanged);
            // 
            // richTxtBoxC
            // 
            this.richTxtBoxC.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxC.Location = new System.Drawing.Point(59, 139);
            this.richTxtBoxC.Margin = new System.Windows.Forms.Padding(4);
            this.richTxtBoxC.Name = "richTxtBoxC";
            this.richTxtBoxC.Size = new System.Drawing.Size(737, 51);
            this.richTxtBoxC.TabIndex = 50;
            this.richTxtBoxC.Text = "";
            this.richTxtBoxC.TextChanged += new System.EventHandler(this.richTxtBoxC_TextChanged);
            // 
            // richTxtBoxB
            // 
            this.richTxtBoxB.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxB.Location = new System.Drawing.Point(59, 80);
            this.richTxtBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.richTxtBoxB.Name = "richTxtBoxB";
            this.richTxtBoxB.Size = new System.Drawing.Size(737, 51);
            this.richTxtBoxB.TabIndex = 50;
            this.richTxtBoxB.Text = "";
            this.richTxtBoxB.TextChanged += new System.EventHandler(this.richTxtBoxB_TextChanged);
            // 
            // richTxtBoxA
            // 
            this.richTxtBoxA.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxA.Location = new System.Drawing.Point(59, 21);
            this.richTxtBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.richTxtBoxA.Name = "richTxtBoxA";
            this.richTxtBoxA.Size = new System.Drawing.Size(737, 51);
            this.richTxtBoxA.TabIndex = 49;
            this.richTxtBoxA.Text = "";
            this.richTxtBoxA.TextChanged += new System.EventHandler(this.richTxtBoxA_TextChanged);
            // 
            // radioE
            // 
            this.radioE.AutoSize = true;
            this.radioE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioE.Location = new System.Drawing.Point(8, 255);
            this.radioE.Margin = new System.Windows.Forms.Padding(4);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(38, 21);
            this.radioE.TabIndex = 4;
            this.radioE.TabStop = true;
            this.radioE.Text = "E";
            this.radioE.UseVisualStyleBackColor = true;
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioD.Location = new System.Drawing.Point(8, 199);
            this.radioD.Margin = new System.Windows.Forms.Padding(4);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(39, 21);
            this.radioD.TabIndex = 3;
            this.radioD.TabStop = true;
            this.radioD.Text = "D";
            this.radioD.UseVisualStyleBackColor = true;
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioC.Location = new System.Drawing.Point(8, 150);
            this.radioC.Margin = new System.Windows.Forms.Padding(4);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(38, 21);
            this.radioC.TabIndex = 2;
            this.radioC.TabStop = true;
            this.radioC.Text = "C";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB.Location = new System.Drawing.Point(8, 97);
            this.radioB.Margin = new System.Windows.Forms.Padding(4);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(38, 21);
            this.radioB.TabIndex = 1;
            this.radioB.TabStop = true;
            this.radioB.Text = "B";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioA.Location = new System.Drawing.Point(8, 41);
            this.radioA.Margin = new System.Windows.Forms.Padding(4);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(38, 21);
            this.radioA.TabIndex = 0;
            this.radioA.TabStop = true;
            this.radioA.Text = "A";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // richTxtBoxSolution
            // 
            this.richTxtBoxSolution.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxSolution.Location = new System.Drawing.Point(38, 411);
            this.richTxtBoxSolution.Margin = new System.Windows.Forms.Padding(4);
            this.richTxtBoxSolution.Name = "richTxtBoxSolution";
            this.richTxtBoxSolution.Size = new System.Drawing.Size(942, 153);
            this.richTxtBoxSolution.TabIndex = 39;
            this.richTxtBoxSolution.Text = "";
            this.richTxtBoxSolution.TextChanged += new System.EventHandler(this.richTxtBoxSolution_TextChanged);
            // 
            // richTxtBoxWordings
            // 
            this.richTxtBoxWordings.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxWordings.Location = new System.Drawing.Point(39, 84);
            this.richTxtBoxWordings.Margin = new System.Windows.Forms.Padding(4);
            this.richTxtBoxWordings.Name = "richTxtBoxWordings";
            this.richTxtBoxWordings.Size = new System.Drawing.Size(409, 293);
            this.richTxtBoxWordings.TabIndex = 38;
            this.richTxtBoxWordings.Text = "";
            this.richTxtBoxWordings.TextChanged += new System.EventHandler(this.richTxtBoxWordings_TextChanged);
            // 
            // FormMakeQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 574);
            this.Controls.Add(this.tabPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMakeQuestion";
            this.Text = "FormMakeQuestion";
            this.tabPage.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.tabQuestion.ResumeLayout(false);
            this.tabQuestion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabQuestion;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox comboBoxMatter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegisterQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RichTextBox richTxtBoxSolution;
        private System.Windows.Forms.RichTextBox richTxtBoxWordings;
        private System.Windows.Forms.Label lblMatter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTxtBoxE;
        private System.Windows.Forms.RichTextBox richTxtBoxD;
        private System.Windows.Forms.RichTextBox richTxtBoxC;
        private System.Windows.Forms.RichTextBox richTxtBoxB;
        private System.Windows.Forms.RichTextBox richTxtBoxA;
        private System.Windows.Forms.Button btnUpdateQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxQuestions;
        private System.Windows.Forms.Label label4;
    }
}