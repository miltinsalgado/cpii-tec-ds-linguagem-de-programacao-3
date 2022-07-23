using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questao_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float m = Convert.ToSingle(textBox1.Text);
                float km = m * 3.6F;

                textBox2.Text = km.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira apenas valores numéricos!");
            }

            catch (OverflowException)
            {
                MessageBox.Show("Por favor, entre com um número menor em tamanho!");
            }
        }
    }
}
