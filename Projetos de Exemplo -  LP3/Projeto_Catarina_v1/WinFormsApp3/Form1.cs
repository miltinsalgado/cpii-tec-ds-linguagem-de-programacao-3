using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        // Método Construtor
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty(chkOpcaoChique.Checked, chkOpcaoSaudavel.Checked, Convert.ToInt32(numPessoas.Value));
            birthdayParty = new BirthdayParty(chkDecoChique.Checked, texto_Escrita.Text, Convert.ToInt32(numPessoas2.Value));
            AtualizarCusto();
            AtualizarCusto2();
        }

        private void numPessoas_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetNumeroDePessoas(Convert.ToInt32(numPessoas.Value));
            AtualizarCusto();
        }

        private void chkOpcaoChique_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.opcaoChique = chkOpcaoChique.Checked;
            AtualizarCusto();
        }

        private void chkOpcaoSaudavel_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.opcaoSaudavel = chkOpcaoSaudavel.Checked;
            AtualizarCusto();
        }

        private void AtualizarCusto()
        {
            txtCusto.Text = Convert.ToString(dinnerParty.CalcularCustoTotal());
        }

        private void numPessoas2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.SetNumeroDePessoas(Convert.ToInt32(numPessoas2.Value));
            AtualizarCusto2();
        }

        private void chkDecoChique_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.opcaoChique = chkDecoChique.Checked;
            AtualizarCusto2();
        }

        private void texto_Escrita_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.escritaBolo = texto_Escrita.Text;
            AtualizarCusto2();
        }

        private void AtualizarCusto2()
        {
            txtCusto2.Text = Convert.ToString(birthdayParty.CalcularCustoTotal());
        }
    }
}
