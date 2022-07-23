namespace Exercício03
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.btnCustomSql = new System.Windows.Forms.Button();
            this.txtCustomSql = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 20;
            this.lstNames.Location = new System.Drawing.Point(12, 12);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(597, 304);
            this.lstNames.TabIndex = 0;
            // 
            // btnLoadStudents
            // 
            this.btnLoadStudents.Location = new System.Drawing.Point(16, 415);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(593, 44);
            this.btnLoadStudents.TabIndex = 6;
            this.btnLoadStudents.Text = "Exibir Alunos";
            this.btnLoadStudents.UseVisualStyleBackColor = true;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);
            // 
            // btnCustomSql
            // 
            this.btnCustomSql.Location = new System.Drawing.Point(363, 322);
            this.btnCustomSql.Name = "btnCustomSql";
            this.btnCustomSql.Size = new System.Drawing.Size(246, 87);
            this.btnCustomSql.TabIndex = 7;
            this.btnCustomSql.Text = "Executar Comando SQL";
            this.btnCustomSql.UseVisualStyleBackColor = true;
            this.btnCustomSql.Click += new System.EventHandler(this.btnCustomSql_Click);
            // 
            // txtCustomSql
            // 
            this.txtCustomSql.Location = new System.Drawing.Point(16, 322);
            this.txtCustomSql.Multiline = true;
            this.txtCustomSql.Name = "txtCustomSql";
            this.txtCustomSql.Size = new System.Drawing.Size(341, 87);
            this.txtCustomSql.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 471);
            this.Controls.Add(this.txtCustomSql);
            this.Controls.Add(this.btnCustomSql);
            this.Controls.Add(this.btnLoadStudents);
            this.Controls.Add(this.lstNames);
            this.Name = "Form1";
            this.Text = "Exercício 03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.Button btnCustomSql;
        private System.Windows.Forms.TextBox txtCustomSql;
    }
}

