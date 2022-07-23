
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMatter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioE = new System.Windows.Forms.RadioButton();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.richTxtBoxWordings = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Tempo:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(545, 28);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 17);
            this.lblTime.TabIndex = 64;
            // 
            // lblMatter
            // 
            this.lblMatter.AutoSize = true;
            this.lblMatter.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatter.Location = new System.Drawing.Point(129, 28);
            this.lblMatter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatter.Name = "lblMatter";
            this.lblMatter.Size = new System.Drawing.Size(0, 17);
            this.lblMatter.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Matéria:";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Enabled = false;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.ForeColor = System.Drawing.Color.Red;
            this.btnAnswer.Location = new System.Drawing.Point(333, 399);
            this.btnAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(917, 146);
            this.btnAnswer.TabIndex = 61;
            this.btnAnswer.Text = "Responder Questão";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 59;
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
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(333, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(917, 296);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternativas";
            // 
            // radioE
            // 
            this.radioE.AutoSize = true;
            this.radioE.Location = new System.Drawing.Point(9, 255);
            this.radioE.Margin = new System.Windows.Forms.Padding(4);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(36, 18);
            this.radioE.TabIndex = 4;
            this.radioE.TabStop = true;
            this.radioE.Text = "E";
            this.radioE.UseVisualStyleBackColor = true;
            this.radioE.CheckedChanged += new System.EventHandler(this.radioE_CheckedChanged);
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Location = new System.Drawing.Point(9, 199);
            this.radioD.Margin = new System.Windows.Forms.Padding(4);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(36, 18);
            this.radioD.TabIndex = 3;
            this.radioD.TabStop = true;
            this.radioD.Text = "D";
            this.radioD.UseVisualStyleBackColor = true;
            this.radioD.CheckedChanged += new System.EventHandler(this.radioD_CheckedChanged);
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(9, 150);
            this.radioC.Margin = new System.Windows.Forms.Padding(4);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(36, 18);
            this.radioC.TabIndex = 2;
            this.radioC.TabStop = true;
            this.radioC.Text = "C";
            this.radioC.UseVisualStyleBackColor = true;
            this.radioC.CheckedChanged += new System.EventHandler(this.radioC_CheckedChanged);
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Location = new System.Drawing.Point(9, 97);
            this.radioB.Margin = new System.Windows.Forms.Padding(4);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(36, 18);
            this.radioB.TabIndex = 1;
            this.radioB.TabStop = true;
            this.radioB.Text = "B";
            this.radioB.UseVisualStyleBackColor = true;
            this.radioB.CheckedChanged += new System.EventHandler(this.radioB_CheckedChanged);
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Location = new System.Drawing.Point(9, 41);
            this.radioA.Margin = new System.Windows.Forms.Padding(4);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(36, 18);
            this.radioA.TabIndex = 0;
            this.radioA.TabStop = true;
            this.radioA.Text = "A";
            this.radioA.UseVisualStyleBackColor = true;
            this.radioA.CheckedChanged += new System.EventHandler(this.radioA_CheckedChanged);
            // 
            // richTxtBoxWordings
            // 
            this.richTxtBoxWordings.BackColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxWordings.Location = new System.Drawing.Point(28, 79);
            this.richTxtBoxWordings.Margin = new System.Windows.Forms.Padding(4);
            this.richTxtBoxWordings.Name = "richTxtBoxWordings";
            this.richTxtBoxWordings.ReadOnly = true;
            this.richTxtBoxWordings.Size = new System.Drawing.Size(297, 466);
            this.richTxtBoxWordings.TabIndex = 56;
            this.richTxtBoxWordings.Text = "";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMakeSimulated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC_LP3.Properties.Resources.test_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 573);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMatter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTxtBoxWordings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMakeSimulated";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMakeSimulated";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMatter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RichTextBox richTxtBoxWordings;
        private System.Windows.Forms.Timer timer;
    }
}