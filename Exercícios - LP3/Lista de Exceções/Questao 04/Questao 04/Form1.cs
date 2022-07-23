using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questao_04
{
    public partial class Form1 : Form
    {
        string pastaDePoemas;

        public Form1()
        {
            InitializeComponent();

            pastaDePoemas = Directory.GetCurrentDirectory();

            pastaDePoemas += @"\Poemas\";

            string[] diretorios = Directory.GetFiles(pastaDePoemas);

            foreach (string diretorio in diretorios)
            {
                string nomeDoPoema = diretorio.Remove(0, pastaDePoemas.Length);
                comboBox1.Items.Add(nomeDoPoema);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader leitor = null;

            try
            {
                string caminhoDoPoema = pastaDePoemas + comboBox1.Text;

                leitor = new StreamReader(caminhoDoPoema);
                textBox1.Text = leitor.ReadToEnd();
            }

            catch(FileNotFoundException)
            {
                MessageBox.Show("Arquivo não encontrado! Por favor, verifique se o arquivo foi deletado ou movido da pasta de poemas!");
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Text = String.Empty;
            }

            finally
            {
                if(leitor != null)
                    leitor.Close();
            }
        }
    }
}
