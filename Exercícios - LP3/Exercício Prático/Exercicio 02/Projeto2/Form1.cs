using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto2
{
    public partial class Form1 : Form
    {
        private DinnerParty dinnerParty;
        private BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty(numericUpDown1.Value, healthyBox.Checked, fancyBox.Checked);
            birthdayParty = new BirthdayParty(numericUpDown1.Value, fancyBirthday.Checked, cakeWriting.Text);
            MostrarCustoDoJantar();
            MostrarCustoDoAniversário();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumeroDePessoas = numericUpDown1.Value;
            MostrarCustoDoJantar();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.decoracaoChique = fancyBox.Checked;
            MostrarCustoDoJantar();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.opcaoSaudavel = healthyBox.Checked;
            MostrarCustoDoJantar();
        }

        private void MostrarCustoDoJantar()
        {
            decimal custoTotal = dinnerParty.CalculaPrecoTotal();
            costLabel.Text = Convert.ToString(custoTotal);
        }

        private void MostrarCustoDoAniversário()
        {
            decimal custoTotal = birthdayParty.CalculaPrecoTotal();
            birthdayCost.Text = Convert.ToString(custoTotal);
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumeroDePessoas = numberBirthday.Value;
            MostrarCustoDoAniversário();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.decoracaoChique = fancyBirthday.Checked;
            MostrarCustoDoAniversário();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.escrita = cakeWriting.Text;
            MostrarCustoDoAniversário();
        }
    }
}
