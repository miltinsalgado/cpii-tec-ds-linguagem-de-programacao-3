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

namespace Questão_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Caminho do arquivo relatório.txt
        string Path = @"C:\Users\milto\Downloads\Desenvolvimento de Sistemas\Linguagem de Programação III\Arquivos Criados - LPIII\relatório.txt";

        // Etapa 1: Adicionar Recibo

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (verificaCamposNulos())
                alertaCamposNulos();
            else
            {
                string nome_passageiro = txtPass.Text;
                string lugar_origem = txtOri.Text;
                string lugar_destino = txtDest.Text;
                string data_viagem = formaDataCompleta();
                string empresa = verificaEmpresa();
                decimal preco_passagem = numVal.Value;

                adicionarRecibo(nome_passageiro, lugar_origem, lugar_destino, data_viagem, empresa, preco_passagem);
            }
        }

        private string verificaEmpresa()
        {
            if (radAE.Checked)
                return "AE";
            if (radEF.Checked)
                return "EF";
            if (radRTA.Checked)
                return "RTA";
            else
                return "EMPRESA_INVÁLIDA";
        }
        private void numDia_ValueChanged(object sender, EventArgs e)
        {
            verificaAnoBissexto();
        }

        private void numMes_ValueChanged(object sender, EventArgs e)
        {
            if (numMes.Value == 2M)
                numDia.Maximum = 29M;
            else
                numDia.Maximum = 31M;

            verificaAnoBissexto();
        }

        private void numAno_ValueChanged(object sender, EventArgs e)
        {
            verificaAnoBissexto();
        }

        private void verificaAnoBissexto()
        {
            int dia = Convert.ToInt32(numDia.Value);
            int mes = Convert.ToInt32(numMes.Value);
            int ano = Convert.ToInt32(numAno.Value);

            if (dia >= 29 && mes == 2)
            {
                if (ano % 4 == 0)
                {
                    if (numAno.Value % 100 == 0)
                        alertaAnoNaoBissexto();
                }
                else
                {
                    if (ano % 400 != 0)
                        alertaAnoNaoBissexto();
                }
            }
        }

        private void alertaAnoNaoBissexto()
        {
            MessageBox.Show("Fevereiro só possui 28 dias em um ano não bissexto! \nAlterando a data para dia 28 de Fevereiro de " + numAno.Value + "!", "ALERTA (código 05)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            numDia.Value = 28M;
        }

        private string formaDataCompleta()
        {
            string dia = Convert.ToString(Convert.ToInt32(numDia.Value));
            string mes = Convert.ToString(Convert.ToInt32(numMes.Value));
            string ano = Convert.ToString(Convert.ToInt32(numAno.Value));

            if (dia.Length == 1)
                dia = "0" + dia;
            if (mes.Length == 1)
                mes = "0" + mes;

            string data_completa = dia + "/" + mes + "/" + ano;
            return data_completa;
        }

        private void alertaCamposNulos()
        {
            if (verificaCamposNulos())
                MessageBox.Show("Campos vazios detectados! \nPor favor, preencha todos os campos para adicionar um recibo!", "ALERTA (código 02)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool verificaCamposNulos()
        {
            if (txtPass.Text == "" || txtOri.Text == "" || txtDest.Text == "")
                return true;
            if (radAE.Checked == false && radEF.Checked == false & radRTA.Checked == false)
                return true;
            else
                return false;
        }

        private void adicionarRecibo(string np, string lo, string ld, string dv, string e, decimal pp)
        {
            Recibo recibo = new Recibo(np, lo, ld, dv, e, pp);

            using (StreamWriter Relatorio = new StreamWriter(Path, true))
                Relatorio.WriteLine(recibo.ToString());

            alertaReciboAdicionado();
        }

        private void alertaReciboAdicionado()
        {
            MessageBox.Show("CONCLUÍDO! \nUm recibo foi adicionado ao relatório!", "SUCESSO (código 01)", MessageBoxButtons.OK);
        }

        // Etapa 2: Resumo por Recibo

        private void alertaRelatorioInexistenteOuVazio()
        {
            MessageBox.Show("Relatório vazio ou inexistente! \nPor favor, crie ou preencha o arquivo de relatório na aba Adicionar Recibo!", "ALERTA (código 04)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        private void btnChecar_Click(object sender, EventArgs e)
        {
            listBoxResumo.Items.Clear();
            if (!File.Exists(Path))
                alertaRelatorioInexistenteOuVazio();
            else
            {
                decimal total_arrecadacao = 0M;
                int cont_viagens = 0;
                string linha = "";
                bool proxima_linha = false;

                int cont_AE = 0, cont_EF = 0, cont_RTA = 0;
                bool AE = false, EF = false, RTA = false;
                decimal total_arrec_AE = 0M, total_arrec_EF = 0M, total_arrec_RTA = 0M;

                using (StreamReader Relatorio = new StreamReader(Path))
                {
                    while (!Relatorio.EndOfStream)
                    {
                        linha = Relatorio.ReadLine();
                        if (linha == "---------------------")
                            cont_viagens++;
                        if (proxima_linha == true)
                        {
                            total_arrecadacao += Convert.ToDecimal(linha);
                            if (AE == true)
                                total_arrec_AE += Convert.ToDecimal(linha);
                            if (EF == true)
                                total_arrec_EF += Convert.ToDecimal(linha);
                            if (RTA == true)
                                total_arrec_RTA += Convert.ToDecimal(linha);

                            AE = false;
                            EF = false;
                            RTA = false;
                            proxima_linha = false;
                        }
                        if (linha == "AE")
                        {
                            AE = true;
                            proxima_linha = true;
                            cont_AE++;
                        }
                        if (linha == "EF")
                        {
                            EF = true;
                            proxima_linha = true;
                            cont_EF++;
                        }
                        if (linha == "RTA")
                        {
                            RTA = true;
                            proxima_linha = true;
                            cont_RTA++;
                        }
                    }
                }

                numViagens.Value = Convert.ToDecimal(cont_viagens);
                numArrec.Value = total_arrecadacao;
                string AE_text = "Air Europe realizou " + cont_AE.ToString() + " voos e arrecadou $" + total_arrec_AE.ToString();
                string EF_text = "Euro Fly realizou " + cont_EF.ToString() + " voos e arrecadou $" + total_arrec_EF.ToString();
                string RTA_text = "Royal Trip Airlines realizou " + cont_RTA.ToString() + " voos e arrecadou $" + total_arrec_RTA.ToString();
                listBoxResumo.Items.Add(AE_text);
                listBoxResumo.Items.Add(EF_text);
                listBoxResumo.Items.Add(RTA_text);
            }
        }

        // Etapa 3: Conferir Recibo

        private void numRecibo_ValueChanged(object sender, EventArgs e)
        {
            if (!File.Exists(Path))
                alertaRelatorioInexistenteOuVazio();
            else
            {
                string linha_relatorio = "";
                int cont_recibos = 0;
                List<string> relatorio = new List<string>();
                using (StreamReader Relatorio = new StreamReader(Path))
                {
                    while (!Relatorio.EndOfStream)
                    {
                        linha_relatorio = Relatorio.ReadLine();
                        if (linha_relatorio == "---------------------")
                            cont_recibos++;
                        relatorio.Add(String.Concat(linha_relatorio, "\r\n"));
                    }
                }

                int num_recibo = Convert.ToInt32(numRecibo.Value);
                if (verificaNumReciboInvalido(num_recibo, cont_recibos))
                {
                    txtRecibo.Text = "";
                    for (int i = 0; i < 7; i++)
                        txtRecibo.Text += relatorio[i];
                }
                else
                {
                    txtRecibo.Text = "";
                    for (int i = (num_recibo - 1) * 7; i < (num_recibo - 1) * 7 + 7; i++)
                        txtRecibo.Text += relatorio[i];
                }
            }
        }
        private bool verificaNumReciboInvalido(int num, int cont)
        {
            if (num > cont || num < 1)
            {
                MessageBox.Show("Número de recibo inválido! \nInformações alteradas para o recibo de número 1!\nPor favor, entre com um número de recibo válido!", "ALERTA (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numRecibo.Value = 1M;
                return true;
            }
            else
                return false;
        }

        
    }
}