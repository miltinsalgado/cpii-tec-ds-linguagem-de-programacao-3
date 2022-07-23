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
    public partial class TelaDeAdicaoDeQuestoes : Form
    {
        string diretorioAtual;
        Questão questao;

        public TelaDeAdicaoDeQuestoes()
        {
            InitializeComponent();

            diretorioAtual = Directory.GetCurrentDirectory();

            diretorioAtual += @"\Questões\";

            string[] diretorios = Directory.GetDirectories(diretorioAtual);

            foreach (string diretorio in diretorios)
            {
                string nomeDaDisciplina = diretorio.Remove(0, diretorioAtual.Length);
                cbBoxDisciplina2.Items.Add(nomeDaDisciplina);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Método clique do botão para fechar o formulário.
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Método para minimizar o formulário.
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Método para voltar à página de Login.
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaDeLogin f3 = new TelaDeLogin();
            f3.Show();
            this.Hide();
        }

        // Método que detecta a alteração da ComboBox das Disciplinas.
        private void cbBoxDisciplina2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarComboBoxQuestao();
            LimparQuestão();
        }

        // Método que cria um objeto questão.
        private void CriarObjetoQuestao()
        {
            string enunciado = txtBoxEnunciado2.Text;
            string alternativaA = txtBoxAltA.Text;
            string alternativaB = txtBoxAltB.Text;
            string alternativaC = txtBoxAltC.Text;
            string alternativaD = txtBoxAltD.Text;
            string alternativaE = txtBoxAltE.Text;
            string resolucao = txtBoxResolucao2.Text;
            int quantAcertos = Convert.ToInt32(numericUpDownAcertos.Value);
            int quantErros = Convert.ToInt32(numericUpDownErros.Value);
            string alternativaCorreta = VerificarAlternativaCorreta();

            questao = new Questão(enunciado, alternativaA, alternativaB, alternativaC, alternativaD, alternativaE, resolucao, quantAcertos, quantErros, alternativaCorreta);
        }

        // Método que atualiza a ComboBox das Questões.
        private void AtualizarComboBoxQuestao()
        {
            cbBoxQuestao2.Items.Clear();
            string diretorioPastaDisciplina = diretorioAtual;
            string nomeDaDisciplina = cbBoxDisciplina2.Text;

            diretorioPastaDisciplina += @"\" + nomeDaDisciplina + @"\";

            string[] diretorios = Directory.GetFiles(diretorioPastaDisciplina);

            foreach (string diretorio in diretorios)
            {
                string nomeDaQuestao = diretorio.Remove(0, diretorioPastaDisciplina.Length);
                cbBoxQuestao2.Items.Add(nomeDaQuestao);
            }
        }

        // Método para verificar e retornar a alternativa correta.
        private string VerificarAlternativaCorreta()
        {
            string alternativaCorreta = String.Empty;

            if (radioA2.Checked)
                alternativaCorreta = "a";

            if (radioB2.Checked)
                alternativaCorreta = "b";

            if (radioC2.Checked)
                alternativaCorreta = "c";

            if (radioD2.Checked)
                alternativaCorreta = "d";

            if (radioE2.Checked)
                alternativaCorreta = "e";

            return alternativaCorreta;
        }

        // Método para abrir e ler um arquivo de questão.
        private void AbrirQuestao()
        {
            string diretorioPastaDisciplina = diretorioAtual + @"\" + cbBoxDisciplina2.Text + @"\";
            string diretorioArquivoQuestao = diretorioPastaDisciplina + @"\" + cbBoxQuestao2.Text;

            List<string> detalhesQuestao = new List<string>();
            using (StreamReader leitorArquivoQuestao = new StreamReader(diretorioArquivoQuestao))  
                    while (!leitorArquivoQuestao.EndOfStream)
                        detalhesQuestao.Add(Convert.ToString(leitorArquivoQuestao.ReadLine()));

            questao = new Questão(detalhesQuestao[0], detalhesQuestao[1], detalhesQuestao[2], detalhesQuestao[3], detalhesQuestao[4], detalhesQuestao[5], detalhesQuestao[6], Convert.ToInt32(detalhesQuestao[7]), Convert.ToInt32(detalhesQuestao[8]), detalhesQuestao[9]);
            MostrarQuestao();
        }

        // Método para mostrar uma questão para o usuário.
        public void MostrarQuestao()
        {
            txtBoxEnunciado2.Text = questao.enunciado;
            txtBoxAltA.Text = questao.alternativaA;
            txtBoxAltB.Text = questao.alternativaB;
            txtBoxAltC.Text = questao.alternativaC;
            txtBoxAltD.Text = questao.alternativaD;
            txtBoxAltE.Text = questao.alternativaE;
            numericUpDownAcertos.Value = Convert.ToDecimal(questao.quantAcertos);
            numericUpDownErros.Value = Convert.ToDecimal(questao.quantErros);
            txtBoxResolucao2.Text = questao.resolucao;
            MarcarAlternativaCorreta(questao.alternativaCorreta);

            MessageBox.Show("Questão carregada com sucesso! \nClique no botão OK para prosseguir!", "TELA DE QUESTÕES (código 01)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para marcar a alternativa correta da questão depois de verificada.
        public void MarcarAlternativaCorreta (string alternativaCorreta)
        {
            if (alternativaCorreta == "a")
                radioA2.Checked = true;
            if (alternativaCorreta == "b")
                radioB2.Checked = true;
            if (alternativaCorreta == "c")
                radioC2.Checked = true;
            if (alternativaCorreta == "d")
                radioD2.Checked = true;
            if (alternativaCorreta == "e")
                radioE2.Checked = true;
        }

        // Método clique para adicionar uma questão na pasta da disciplina.
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios(1))
                MessageBox.Show("Campo(s) vazio(s) detectado(s)! \nPor favor, preencha todos os campos!", "TELA DE QUESTÕES (código 02)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                CriarObjetoQuestao();
                string nomeDaDisciplina = cbBoxDisciplina2.Text;
                int quantArquivos = cbBoxQuestao2.Items.Count;
                string nomeArquivo = String.Empty;

                nomeArquivo = Convert.ToString(quantArquivos + 1);
                if (nomeArquivo.Length == 1)
                    nomeArquivo = "00" + nomeArquivo + ".txt";
                else
                    nomeArquivo = "0" + nomeArquivo + ".txt";

                string diretorioArquivoCriado = diretorioAtual + @"\" + nomeDaDisciplina + @"\" + nomeArquivo;
                using (StreamWriter novoArquivo = new StreamWriter(diretorioArquivoCriado))
                    novoArquivo.WriteLine(questao.ToString());

                AtualizarComboBoxQuestao();
                MessageBox.Show("Questão " + nomeArquivo + " cadastrada com sucesso! \nClique no botão OK para prosseguir!", "TELA DE CADASTRO DE QUESTÕES (código 05)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparQuestão();
            }
        }

        // Método clique para atualizar uma questão na pasta da disciplina.
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios(2))
                MessageBox.Show("Campo(s) vazio(s) detectado(s)! \nPor favor, preencha todos os campos!", "TELA DE QUESTÕES (código 02)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                CriarObjetoQuestao();
                string nomeDaDisciplina = cbBoxDisciplina2.Text;
                string nomeArquivo = String.Empty;

                nomeArquivo = cbBoxQuestao2.Text;
                string diretorioArquivoAtualizado = diretorioAtual + @"\" + nomeDaDisciplina + @"\" + nomeArquivo;
                using (StreamWriter novoArquivo = new StreamWriter(diretorioArquivoAtualizado))
                    novoArquivo.WriteLine(questao.ToString());

                MessageBox.Show("Questão " + nomeArquivo + " atualizada com sucesso! \nClique no botão OK para prosseguir!", "TELA DE CADASTRO DE QUESTÕES (código 05)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método para verificar se há campos vazios no formulário.
        private bool VerificarCamposVazios(int num)
        {
            if (String.IsNullOrEmpty(cbBoxDisciplina2.Text))
                return true;

            if (num == 2)
            {
                if (String.IsNullOrEmpty(cbBoxQuestao2.Text))
                    return true;
            }

            if (String.IsNullOrEmpty(txtBoxEnunciado2.Text))
                return true;

            if (String.IsNullOrEmpty(txtBoxAltA.Text))
                return true;

            if (String.IsNullOrEmpty(txtBoxAltB.Text))
                return true;

            if (String.IsNullOrEmpty(txtBoxAltC.Text))
                return true;

            if (String.IsNullOrEmpty(txtBoxAltD.Text))
                return true;

            if (String.IsNullOrEmpty(txtBoxAltE.Text))
                return true;

            if (String.IsNullOrEmpty(txtBoxResolucao2.Text))
                return true;

            if (!radioA2.Checked && !radioB2.Checked && !radioC2.Checked && !radioD2.Checked && !radioE2.Checked)
                return true;
            else
                return false;
        }

        // Método que detecta a alteração da ComboBox das Questões.
        private void cbBoxQuestao2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbrirQuestao();
        }

        // Método clique que chama o método de limpeza.
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparQuestão();
        }

        // Método para limpar a questão.
        private void LimparQuestão()
        {
            txtBoxEnunciado2.Text = String.Empty;
            txtBoxAltA.Text = String.Empty;
            txtBoxAltB.Text = String.Empty;
            txtBoxAltC.Text = String.Empty;
            txtBoxAltD.Text = String.Empty;
            txtBoxAltE.Text = String.Empty;
            txtBoxResolucao2.Text = String.Empty;
            numericUpDownAcertos.Value = 0M;
            numericUpDownErros.Value = 0M;
            radioA2.Checked = false;
            radioB2.Checked = false;
            radioC2.Checked = false;
            radioD2.Checked = false;
            radioE2.Checked = false;
        }

        // Método TextChanged que detecta alteração no texto da TextBox do Enunciado.
        private void txtBoxEnunciado2_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxEnunciado2.Text.Contains('\n'))
            {
                MessageBox.Show("O sistema só aceita textos sem quebra de linha! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE USUÁRIOS (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxEnunciado2.Text = String.Empty;
            }
        }

        // Método TextChanged que detecta alteração no texto da TextBox da Alternativa A.
        private void txtBoxAltA_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxAltA.Text.Contains('\n'))
            {
                MessageBox.Show("O sistema só aceita textos sem quebra de linha! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE QUESTÕES (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxAltA.Text = String.Empty;
            }
        }

        // Método TextChanged que detecta alteração no texto da TextBox da Alternativa B.
        private void txtBoxAltB_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxAltB.Text.Contains('\n'))
            {
                MessageBox.Show("O sistema só aceita textos sem quebra de linha! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE QUESTÕES (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxAltB.Text = String.Empty;
            }
        }

        // Método TextChanged que detecta alteração no texto da TextBox da Alternativa C.
        private void txtBoxAltC_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxAltC.Text.Contains('\n'))
            {
                MessageBox.Show("O sistema só aceita textos sem quebra de linha! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE QUESTÕES (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxAltC.Text = String.Empty;
            }
        }

        // Método TextChanged que detecta alteração no texto da TextBox da Alternativa D.
        private void txtBoxAltD_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxAltD.Text.Contains('\n'))
            {
                MessageBox.Show("O sistema só aceita textos sem quebra de linha! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE QUESTÕES (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxAltD.Text = String.Empty;
            }
        }

        // Método TextChanged que detecta alteração no texto da TextBox da Alternativa E.
        private void txtBoxAltE_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxAltE.Text.Contains('\n'))
            {
                MessageBox.Show("O sistema só aceita textos sem quebra de linha! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE QUESTÕES (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxAltE.Text = String.Empty;
            }
        }

        // Método TextChanged que detecta alteração no texto da TextBox da Resolução.
        private void txtBoxResolucao2_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxResolucao2.Text.Contains('\n'))
            {
                MessageBox.Show("O sistema só aceita textos sem quebra de linha! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE QUESTÕES (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxResolucao2.Text = String.Empty;
            }
        }
    }
}
