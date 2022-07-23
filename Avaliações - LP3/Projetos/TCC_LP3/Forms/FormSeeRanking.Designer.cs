
namespace TCC_LP3.Forms
{
    partial class FormSeeRanking
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
            this.listRanking = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listRanking
            // 
            this.listRanking.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRanking.FormattingEnabled = true;
            this.listRanking.ItemHeight = 17;
            this.listRanking.Location = new System.Drawing.Point(12, 13);
            this.listRanking.Name = "listRanking";
            this.listRanking.Size = new System.Drawing.Size(1239, 548);
            this.listRanking.TabIndex = 0;
            // 
            // FormSeeRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 574);
            this.Controls.Add(this.listRanking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSeeRanking";
            this.Text = "FormSeeRanking";
            this.Load += new System.EventHandler(this.FormSeeRanking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listRanking;
    }
}