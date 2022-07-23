using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestaoJuros
{
    public partial class Form1 : Form
    {
        private JurosSimples jurosSimples;
        private JurosCompostos jurosCompostos;

        public Form1()
        {
            InitializeComponent();
            jurosSimples = new JurosSimples(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value);
            jurosCompostos = new JurosCompostos(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value);
            CalcularJuros();
        }

        private void CalcularJuros()
        {
            if (radioButton1.Checked)
                costLabel.Text = jurosSimples.CalcularJuros().ToString("C");
            else
                costLabel.Text = jurosCompostos.CalcularJuros().ToString("C");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            jurosSimples.SetCapital(numericUpDown1.Value);
            jurosCompostos.SetCapital(numericUpDown1.Value);
            CalcularJuros();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            jurosSimples.SetTaxa(numericUpDown2.Value);
            jurosCompostos.SetTaxa(numericUpDown2.Value);
            CalcularJuros();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            jurosSimples.SetTempo(numericUpDown3.Value);
            jurosCompostos.SetTempo(numericUpDown3.Value);
            CalcularJuros();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CalcularJuros();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CalcularJuros();
        }
    }
}
