using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbSimples_CheckedChanged(object sender, EventArgs e)
        {
            updateValues();
        }

        private void rdbComposto_CheckedChanged(object sender, EventArgs e)
        {
            updateValues();
        }

        private void numCapital_ValueChanged(object sender, EventArgs e)
        {
            updateValues();
        }

        private void numTaxa_ValueChanged(object sender, EventArgs e)
        {
            updateValues();
        }

        private void numTempo_ValueChanged(object sender, EventArgs e)
        {
            updateValues();
        }

        private void updateValues()
        {
            if(rdbComposto.Checked)
            {
                JurosCompostos jurosCompostos = new JurosCompostos(Convert.ToInt32(numTempo.Value), Convert.ToDouble(numTaxa.Value/100), Convert.ToDouble(numCapital.Value));
                txtJuros.Text = jurosCompostos.CalcularJuros().ToString("C");
            }
            else if(rdbSimples.Checked)
            {
                JurosSimples jurosSimples = new JurosSimples(Convert.ToInt32(numTempo.Value), Convert.ToDouble(numTaxa.Value/100), Convert.ToDouble(numCapital.Value));
                txtJuros.Text = jurosSimples.CalcularJuros().ToString("C");
            }
        }
    }
}
