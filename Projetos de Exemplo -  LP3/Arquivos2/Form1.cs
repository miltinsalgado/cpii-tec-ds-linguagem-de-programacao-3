using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquivos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            //Pode mudar algum atributo de folderDialog aqui...
            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("O usuário clicou em OK!");
                MessageBox.Show("O caminho da pasta clicada é: " +
                folderDialog.SelectedPath);
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("O usuário clicou em Cancel!");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = @"C:\";
            saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = saveDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("O usuário clicou em OK!");
                MessageBox.Show("O caminho do arquivo a ser salvo é: " +
                saveDialog.FileName);
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("O usuário clicou em Cancel!");
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = @"C:\";
            openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("O usuário clicou em OK!");
                MessageBox.Show("O caminho do arquivo clicado é: " +
                openDialog.FileName);
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("O usuário clicou em Cancel!");
            }
        }
    }
}
