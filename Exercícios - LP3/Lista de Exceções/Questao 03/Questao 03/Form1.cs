using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questao_03
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
                decimal termoInicial = numericUpDown1.Value;
                decimal razao = numericUpDown2.Value;
                decimal n = numericUpDown3.Value;

                decimal an = termoInicial + (n - 1) * razao;
                numericUpDown4.Value = an;
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("O valor calculado para o termo geral é menor do que o mínimo possível ou é maior do que o máximo possível, e portanto não pode ser apresentado como resultado!");
            }
        }
    }
}
