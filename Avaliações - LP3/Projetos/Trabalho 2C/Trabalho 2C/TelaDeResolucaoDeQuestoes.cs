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
using System.Runtime.InteropServices;

namespace Trabalho_2C
{
    public partial class TelaDeResolucaoDeQuestoes : Form
    {
        List<string> diretoriosUsados = new List<string>();
        string diretorioAtual;
        string diretorioArquivo;
        string arquivoUsado;

        Questão questao;

        // Inicialização do Sistema de Resolução, atribuindo o diretorio das questões à uma variável.
        public TelaDeResolucaoDeQuestoes()
        {
            InitializeComponent();

            diretorioAtual = Directory.GetCurrentDirectory();

            diretorioAtual += @"\Questões\";

            string[] diretorios = Directory.GetDirectories(diretorioAtual);

            foreach(string diretorio in diretorios)
            {
                string nomeDaDisciplina = diretorio.Remove(0, diretorioAtual.Length);
                cbBoxDisciplina1.Items.Add(nomeDaDisciplina);
            }
        }

        // Importação de DLL para permitir a movimentação do formulário.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Método clique do botão para fechar o formulário.
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Método para o formulário se mover.
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Método para minimizar o formulário.
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Método para voltar à página Inicial.
        private void btnTelaLogin_Click(object sender, EventArgs e)
        {
            TelaInicial f1 = new TelaInicial();
            f1.Show();
            this.Hide();
        }

        // Método que detecta a alteração da ComboBox das Disciplinas.
        private void cbBoxDisciplina1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pastaDisciplina = cbBoxDisciplina1.Text;
            string[] caminhosArquivos = Directory.GetFiles(diretorioAtual + @"\" + pastaDisciplina, "*.txt");
            radioA1.Text = "Alternativa A";
            radioB1.Text = "Alternativa B";
            radioC1.Text = "Alternativa C";
            radioD1.Text = "Alternativa D";
            radioE1.Text = "Alternativa E";
            labelPercentAcertos.Text = "0% de acertos";
            pgrsBarAcertos.Value = 0;

            if (caminhosArquivos.Length == 0)
                MessageBox.Show("Não há questões de " + cbBoxDisciplina1.Text + "!\nClique no botão OK para prosseguir!", "TELA DE RESOLUÇÃO (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (caminhosArquivos.Length != 0)
            {
                btnProxima.Enabled = true;
                RadioChanger(true, false);
                btnResponder.Enabled = false;
                SortearQuestao();
            }

            else
            {
                txtBoxEnunciado1.Text = String.Empty;
                txtBoxResolucao1.Text = String.Empty;
                RadioChanger(false, false);
                btnProxima.Enabled = false;
                btnResponder.Enabled = false;
            }
        }

        // Método para sortear uma questão da pasta de disciplina, de forma aleatória, além de filtrar se a questão já foi respondida
        private void SortearQuestao()
        {
            int cont = 0;
            while (true)
            {
                bool used = false;
                string pasta_disciplina = cbBoxDisciplina1.Text;
                string[] caminhosArquivos = Directory.GetFiles(diretorioAtual + @"\" + pasta_disciplina, "*.txt");
                if (caminhosArquivos.Length != 0)
                {
                    Random rand = new Random();
                    diretorioArquivo = caminhosArquivos[rand.Next(caminhosArquivos.Length)];
                    if (caminhosArquivos.Length != 1)
                    {
                        if (arquivoUsado == diretorioArquivo)
                        {
                            while (arquivoUsado == diretorioArquivo)
                            {
                                rand = new Random();
                                diretorioArquivo = caminhosArquivos[rand.Next(caminhosArquivos.Length)];
                            }
                        }
                        arquivoUsado = diretorioArquivo;
                    }
                }

                List<string> diretoriosUsadosDaMateria = new List<string>();
                for (int i = 0; i < diretoriosUsados.Count; i++)
                    if (diretoriosUsados[i].Contains(pasta_disciplina))
                        diretoriosUsadosDaMateria.Add(diretoriosUsados[i]);

                if (caminhosArquivos.Length == diretoriosUsadosDaMateria.Count + 1 && cont == 0)
                {
                    MessageBox.Show("Essa é a última questão de " + cbBoxDisciplina1.Text + "!\nClique no botão OK para prosseguir!", "TELA DE RESOLUÇÃO (código 02)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnProxima.Enabled = false;
                    cont = 1;
                }
                if (caminhosArquivos.Length == diretoriosUsadosDaMateria.Count && cont == 0)
                {
                    MessageBox.Show("Não há mais questões de " + cbBoxDisciplina1.Text + "!\nClique no botão OK para prosseguir!", "TELA DE RESOLUÇÃO (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoxEnunciado1.Text = String.Empty;
                    txtBoxResolucao1.Text = String.Empty;
                    RadioChanger(false, false);
                    btnResponder.Enabled = false;
                    btnProxima.Enabled = false;
                    cont = 1;
                    break;
                }
                for (int i = 0; i < diretoriosUsadosDaMateria.Count; i++)
                {
                    if (diretoriosUsadosDaMateria[i] == diretorioArquivo)
                    {
                        used = true;
                        break;
                    }
                }
                if (used == false)
                {
                    DetalharQuestao(diretorioArquivo);
                    break;
                }
            }
        }
        
        // Método para deixar o código mais compacto e eficiente.
        private void RadioChanger(bool Enabler, bool Checker)
        {
            radioA1.Enabled = Enabler;
            radioB1.Enabled = Enabler;
            radioC1.Enabled = Enabler;
            radioD1.Enabled = Enabler;
            radioE1.Enabled = Enabler;
            radioA1.Checked = Checker;
            radioB1.Checked = Checker;
            radioC1.Checked = Checker;
            radioD1.Checked = Checker;
            radioE1.Checked = Checker;
        }

        // Método para buscar uma questão da pasta de disciplina, através de seu diretório.
        private void DetalharQuestao(string arquivo)
        {
            List<string> detalhesQuestao = new List<string>();
            using (StreamReader leitorQuestao = new StreamReader(arquivo))
                while (!leitorQuestao.EndOfStream)
                    detalhesQuestao.Add(Convert.ToString(leitorQuestao.ReadLine()));

            questao = new Questão(detalhesQuestao[0], detalhesQuestao[1], detalhesQuestao[2] , detalhesQuestao[3], detalhesQuestao[4], detalhesQuestao[5], detalhesQuestao[6], Convert.ToInt32(detalhesQuestao[7]), Convert.ToInt32(detalhesQuestao[8]), detalhesQuestao[9]);
            MostrarQuestao();
        }

        // Método para mostrar uma questão através dos atributos do objeto "questao".
        private void MostrarQuestao()
        {
            txtBoxEnunciado1.Text = questao.enunciado;
            radioA1.Text = questao.alternativaA;
            radioB1.Text = questao.alternativaB;
            radioC1.Text = questao.alternativaC;
            radioD1.Text = questao.alternativaD;
            radioE1.Text = questao.alternativaE;
            txtBoxResolucao1.Text = String.Empty;
            CalcularPercentual();

            MessageBox.Show("Questão carregada com sucesso! \nClique no botão OK para prosseguir!", "TELA DE RESOLUÇÃO (código 01)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para calcular o percentual de acertos da questão e mostrá-lo na label e atualizá-lo na barra de progresso.
        private void CalcularPercentual()
        {
            int totalRespostas = questao.quantAcertos + questao.quantErros;
            int percentualAcertos = 0;

            if (totalRespostas != 0)
                percentualAcertos = 100 * questao.quantAcertos / totalRespostas;

            labelPercentAcertos.Text = Convert.ToString(percentualAcertos.ToString() + "% de acertos");
            pgrsBarAcertos.Value = percentualAcertos;
        }

        // Método clique do botão responder, que chama dois métodos para atualizar valores.
        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (diretoriosUsados.Contains(diretorioArquivo))
            {
                MessageBox.Show("Você já respondeu essa pergunta! \nClique no botão OK para prosseguir!", "TELA DE RESOLUÇÃO (código 04)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RadioChanger(false, false);
                btnResponder.Enabled = false;
                return;
            }
            diretoriosUsados.Add(diretorioArquivo);

            bool resultado = verificaAlternativaCorreta();
            if (resultado == true)
            {
                MessageBox.Show("Parabéns! Você acertou a questão! \nClique no botão OK para prosseguir!", "TELA DE RESOLUÇÃO (código 04)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                questao.quantAcertos++;
            }

            else
            {
                MessageBox.Show("Que pena! Você errou a questão! \nClique no botão OK para prosseguir!", "TELA DE RESOLUÇÃO (código 04)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                questao.quantErros++;
                txtBoxResolucao1.Text += "Alternativa correta: " + questao.alternativaCorreta.ToUpper() + "\r\n";
            }

            AtualizarValorNoArquivo();
            CalcularPercentual();
            txtBoxResolucao1.Text += questao.resolucao;
        }

        // Atualiza os dados de uma questão, alterando unicamente o valor de acertos e erros.
        private void AtualizarValorNoArquivo()
        {
            using (StreamWriter novosDetalhesQuestao = new StreamWriter(diretorioArquivo))
                novosDetalhesQuestao.WriteLine(questao.ToString());
        }

        // Método para verificar se o usuário entrou com uma alternativa correta.
        private bool verificaAlternativaCorreta()
        {
            string alternativaCorreta = questao.alternativaCorreta;
            string alternativaSelecionada = String.Empty;

            if (radioA1.Checked)
                alternativaSelecionada = "a";

            if (radioB1.Checked)
                alternativaSelecionada = "b";

            if (radioC1.Checked)
                alternativaSelecionada = "c";

            if (radioD1.Checked)
                alternativaSelecionada = "d";

            if (radioE1.Checked)
                alternativaSelecionada = "e";

            if (alternativaCorreta == alternativaSelecionada)
                return true;
            else
                return false;
        }

        // Método para sortear e mostrar uma próxima questão.
        private void btnProxima_Click(object sender, EventArgs e)
        {
            RadioChanger(true, false);
            btnResponder.Enabled = false;
            SortearQuestao();
        }

        // Método para verificar se a caixa de resposta A foi alterada.
        private void radioA1_CheckedChanged(object sender, EventArgs e)
        {
            btnResponder.Enabled = true;
        }

        // Método para veríficar se a caixa de resposta B foi alterada.
        private void radioB1_CheckedChanged(object sender, EventArgs e)
        {
            btnResponder.Enabled = true;
        }

        // Método para veríficar se a caixa de resposta C foi alterada.
        private void radioC1_CheckedChanged(object sender, EventArgs e)
        {
            btnResponder.Enabled = true;
        }

        // Método para veríficar se a caixa de resposta D foi alterada.
        private void radioD1_CheckedChanged(object sender, EventArgs e)
        {
            btnResponder.Enabled = true;
        }

        // Método para veríficar se a caixa de resposta E foi alterada.
        private void radioE1_CheckedChanged(object sender, EventArgs e)
        {
            btnResponder.Enabled = true;
        }
    }
}
