
namespace Questão_02
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
            this.notepadTextBox = new System.Windows.Forms.RichTextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notepadTextBox
            // 
            this.notepadTextBox.Location = new System.Drawing.Point(12, 12);
            this.notepadTextBox.Name = "notepadTextBox";
            this.notepadTextBox.Size = new System.Drawing.Size(776, 348);
            this.notepadTextBox.TabIndex = 0;
            this.notepadTextBox.Text = "";
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(146, 366);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(246, 72);
            this.button_Open.TabIndex = 1;
            this.button_Open.Text = "Abrir Arquivo";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(398, 366);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(246, 72);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Salvar Arquivo";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.notepadTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bloco de Notas Beta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox notepadTextBox;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Save;
    }
}

