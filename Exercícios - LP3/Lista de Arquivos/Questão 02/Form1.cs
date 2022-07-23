using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Questão_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.InitialDirectory = @"C:\";
            openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            DialogResult result = openDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (StreamReader leitor_arq = new StreamReader(openDialog.FileName))
                {
                    while (!leitor_arq.EndOfStream)
                    {
                        notepadTextBox.Text += leitor_arq.ReadLine() + "\n";                    
                    }
                    MessageBox.Show("O arquivo" + openDialog.FileName + " foi aberto com sucesso!");
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("A operação foi cancelada!");
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.InitialDirectory = @"C:\";
            saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            DialogResult result = saveDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (StreamWriter escritor_arq = new StreamWriter(saveDialog.FileName))
                {
                    escritor_arq.Write(notepadTextBox.Text);
                    MessageBox.Show("O arquivo" + saveDialog.FileName + " foi salvo com sucesso!");
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("A operação foi cancelada!");
            }
        }
    }
}
