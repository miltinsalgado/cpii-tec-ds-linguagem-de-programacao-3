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

namespace TCC_LP3.Forms
{
    public partial class FormAnswerQuestons : Form
    {
        DataBaseManager gerenciador = new DataBaseManager("DataBase");
        DataTable tableQuestion = new DataTable();
        List<Questao> listaQuestao = new List<Questao>();
        string materia = string.Empty;
        int indice = 0;

        public FormAnswerQuestons()
        {
            InitializeComponent();
            DataTable tableMateria = new DataTable();
            tableMateria = gerenciador.ConsultarBanco($"SELECT Nome FROM Materia");

            for (int i = 0; i < tableMateria.Rows.Count; i++)
                comboBoxMatter.Items.Add(tableMateria.Rows[i]["Nome"]);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            materia = comboBoxMatter.Text;
            lblMatter.Text = materia;
            bool checkcbBox = checkComboBox();

            if (checkcbBox)
                MessageBox.Show("Selecione uma matéria para começar!");
            else
            {
                DataTable tableImagens = new DataTable();

                tableImagens = gerenciador.ConsultarBanco($"SELECT Imagem FROM Materia WHERE Nome = '{materia}'");

                string imagemPath = tableImagens.Rows[0]["Imagem"].ToString();
                string path = $@"{Directory.GetCurrentDirectory()}\..\..\{imagemPath}";
                tabPage.SelectedTab = tabQuestions;
                tabQuestions.BackgroundImage = Image.FromFile(path);

                tableQuestion = new DataTable();
                tableQuestion = generateQuestionsTable(materia);
                listaQuestao = new List<Questao>();
                listaQuestao = generateQuestionsList(tableQuestion);
                showQuestion(listaQuestao, indice);
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            bool acertou = checkAnswer(listaQuestao[indice]);

            if (acertou)
            {
                listaQuestao[indice].acertos++;
                MessageBox.Show("Parabéns! Você acertou a questão!");
                gerenciador.AtualizarBanco($"UPDATE Questao SET Acertos = {listaQuestao[indice].acertos} WHERE Cod_Questao = '{listaQuestao[indice].codigo}'");
            }
                
            else
            {
                listaQuestao[indice].erros++;
                MessageBox.Show("Que triste! Vodê errou a questão!");
                gerenciador.AtualizarBanco($"UPDATE Questao SET Erros = {listaQuestao[indice].erros} WHERE Cod_Questao = '{listaQuestao[indice].codigo}'");
            }
            showQuestionSolution(listaQuestao[indice]);
            enableNextQuestionButton();
            disableAnswerQuestionButton();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            indice++;
            tableQuestion = new DataTable();
            tableQuestion = generateQuestionsTable(materia);
            listaQuestao = new List<Questao>();
            listaQuestao = generateQuestionsList(tableQuestion);
            showQuestion(listaQuestao, indice);
        }

        private void showQuestion(List<Questao> listaQuestao, int indice)
        {
            bool ultimaQuestao = checkLastQuestion();

            if (listaQuestao.Count == 0)
            {
                MessageBox.Show("Não há questões de " + materia + "!");
                disableRadioButtons();
            }
            else if (ultimaQuestao)
            {
                MessageBox.Show("Todas as questões já foram respondidas!");
                disableRadioButtons();
            }
            else
            {
                richTxtBoxWordings.Text = listaQuestao[indice].enunciado;
                radioA.Text = listaQuestao[indice].altA;
                radioB.Text = listaQuestao[indice].altB;
                radioC.Text = listaQuestao[indice].altC;
                radioD.Text = listaQuestao[indice].altD;
                radioE.Text = listaQuestao[indice].altE;
                checkDifficulty();
            }
            richTxtBoxSolution.Text = string.Empty;
            clearRadioButtons();
            disableAnswerQuestionButton();
            disableNextQuestionButton();
        }

        private void showQuestionSolution(Questao questao)
        {
            richTxtBoxSolution.Text = questao.resolucao;
        }

        private bool checkLastQuestion()
        {
            if (indice == listaQuestao.Count)
                return true;
            else
                return false;
        }

        private bool checkAnswer(Questao questao)
        {
            char altSelecionada = 'X';

            if (radioA.Checked)
                altSelecionada = 'A';
            if (radioB.Checked)
                altSelecionada = 'B';
            if (radioC.Checked)
                altSelecionada = 'C';
            if (radioD.Checked)
                altSelecionada = 'D';
            if (radioE.Checked)
                altSelecionada = 'E';

            if (altSelecionada == questao.altCorreta)
                return true;
            else
                return false;
        }

        private List<Questao> generateQuestionsList(DataTable tableQuestao)
        {
            List<Questao> listQuestao = new List<Questao>();
            Questao questao = null;
            foreach (DataRow row in tableQuestao.Rows)
            {
                int codigo = (int)row["Cod_Questao"];
                string enunciado = (string)row["Enunciado"];
                string altA = (string)row["AltA"];
                string altB = (string)row["AltB"];
                string altC = (string)row["AltC"];
                string altD = (string)row["AltD"];
                string altE = (string)row["AltE"];
                char altCorreta = Convert.ToChar(row["AltCorreta"]);
                string resolucao = (string)row["Resolucao"];
                int acertos = (int)row["Acertos"];
                int erros = (int)row["Erros"];

                questao = new Questao(codigo, enunciado, altA, altB, altC, altD, altE, altCorreta, resolucao, acertos, erros);
                listQuestao.Add(questao);
            }

            return listQuestao;
        }

        private DataTable generateQuestionsTable(string materia)
        {
            DataTable tableQuestao = new DataTable();
            tableQuestao = gerenciador.ConsultarBanco($"SELECT Cod_Questao, Enunciado, AltA, AltB, AltC, AltD, AltE, AltCorreta, Resolucao, Q.Cod_Materia, Acertos, Erros FROM Questao Q INNER JOIN Materia M ON Q.Cod_Materia = M.Cod_Materia WHERE M.Nome = '{materia}' ORDER BY NEWID()");
            return tableQuestao;
        }

        private void clearRadioButtons()
        {
            radioA.Checked = false;
            radioB.Checked = false;
            radioC.Checked = false;
            radioD.Checked = false;
            radioE.Checked = false;
        }

        private void enableAnswerQuestionButton()
        {
            btnAnswer.Enabled = true;
            btnAnswer.ForeColor = Color.Black;
        }

        private void disableAnswerQuestionButton()
        {
            btnAnswer.Enabled = false;
            btnAnswer.ForeColor = Color.Red;
        }

        private void enableNextQuestionButton()
        {
            btnNextQuestion.Enabled = true;
            btnNextQuestion.ForeColor = Color.Black;
        }

        private void disableNextQuestionButton()
        {
            btnNextQuestion.Enabled = false;
            btnNextQuestion.ForeColor = Color.Red;
        }

        private void radioA_CheckedChanged(object sender, EventArgs e)
        {
            enableAnswerQuestionButton();
        }

        private void radioB_CheckedChanged(object sender, EventArgs e)
        {
            enableAnswerQuestionButton();
        }

        private void radioC_CheckedChanged(object sender, EventArgs e)
        {
            enableAnswerQuestionButton();
        }

        private void radioD_CheckedChanged(object sender, EventArgs e)
        {
            enableAnswerQuestionButton();
        }

        private void radioE_CheckedChanged(object sender, EventArgs e)
        {
            enableAnswerQuestionButton();
        }

        private void disableRadioButtons()
        {
            clearRadioButtons();
            radioA.Enabled = false;
            radioB.Enabled = false;
            radioC.Enabled = false;
            radioD.Enabled = false;
            radioE.Enabled = false;
        }

        private void checkDifficulty()
        {
            int percentual = listaQuestao[indice].PercentualDeAcertos();
            lblPercent.Text = percentual.ToString() + "% de Acertos";
            progressBar.Value = percentual;

            if (percentual >= 0 && percentual <= 25)
            {
                lblDifficulty.ForeColor = Color.Red;
                lblDifficulty.Text = "DIFÍCIL";
            }

            else if (percentual > 25 && percentual <= 50)
            {
                lblDifficulty.ForeColor = Color.Yellow;
                lblDifficulty.Text = "MÉDIA";
            }

            else if (percentual > 50 && percentual <= 100)
            {
                lblDifficulty.ForeColor = Color.Green;
                lblDifficulty.Text = "FÁCIL";
            }
        }

        private bool checkComboBox()
        {
            if (string.IsNullOrEmpty(comboBoxMatter.Text))
                return true;
            else
                return false;
        }
    }
}