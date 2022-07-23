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
    public partial class FormMakeQuestion : Form
    {
        DataBaseManager gerenciador = new DataBaseManager("DataBase");
        DataTable tableQuestion = new DataTable();
        List<Questao> listaQuestao = new List<Questao>();
        string materia = string.Empty;
        int indice = 0;

        public FormMakeQuestion()
        {
            InitializeComponent();
            DataTable tableMateria = new DataTable();
            tableMateria = gerenciador.ConsultarBanco($"SELECT Nome FROM Materia");

            for (int i = 0; i < tableMateria.Rows.Count; i++)
                comboBoxMatter.Items.Add(tableMateria.Rows[i]["Nome"]);
        }

        private void btnStart_Click_1(object sender, EventArgs e)
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
                tabPage.SelectedTab = tabQuestion;
                tabQuestion.BackgroundImage = Image.FromFile(path);

                updateComboBoxQuestions();
            }
        }

        private void btnRegisterQuestion_Click(object sender, EventArgs e)
        {
            if (comboBoxQuestions.SelectedIndex >= 0)
                MessageBox.Show("Não é possível cadastrar ao selecionar uma questão para edição e atualização!");
            else
                registerQuestion();
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            if (comboBoxQuestions.SelectedIndex <= -1)
                MessageBox.Show("Não é possível atualizar e editar sem selecionar uma questão!");
            else
                updateQuestion();
        }

        private void showQuestion(List<Questao> listaQuestao, int indice)
        {
            richTxtBoxWordings.Text = listaQuestao[indice].enunciado;
            richTxtBoxA.Text = listaQuestao[indice].altA;
            richTxtBoxB.Text = listaQuestao[indice].altB;
            richTxtBoxC.Text = listaQuestao[indice].altC;
            richTxtBoxD.Text = listaQuestao[indice].altD;
            richTxtBoxE.Text = listaQuestao[indice].altE;
            richTxtBoxSolution.Text = listaQuestao[indice].resolucao;
            checkAnswer(listaQuestao[indice]);
        }

        private void checkAnswer(Questao questao)
        {
            char altCorreta = questao.altCorreta;

            if (altCorreta == 'A')
                radioA.Checked = true;

            else if (altCorreta == 'B')
                radioB.Checked = true;

            else if (altCorreta == 'C')
                radioC.Checked = true;

            else if (altCorreta == 'D')
                radioD.Checked = true;

            else if (altCorreta == 'E')
                radioE.Checked = true;
        }

        private char generateAnswer()
        {
            char altCorreta = 'X';

            if (radioA.Checked)
                altCorreta = 'A';

            else if (radioB.Checked)
                altCorreta = 'B';

            else if (radioC.Checked)
                altCorreta = 'C';

            else if (radioD.Checked)
                altCorreta = 'D';

            else if (radioE.Checked)
                altCorreta = 'E';

            return altCorreta;
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

        private void radioA_CheckedChanged(object sender, EventArgs e)
        {
            checkNullOrEmptyCamps();
        }

        private void radioB_CheckedChanged(object sender, EventArgs e)
        {
            checkNullOrEmptyCamps();
        }

        private void radioC_CheckedChanged(object sender, EventArgs e)
        {
            checkNullOrEmptyCamps();
        }

        private void radioD_CheckedChanged(object sender, EventArgs e)
        {
            checkNullOrEmptyCamps();
        }

        private void radioE_CheckedChanged(object sender, EventArgs e)
        {
            checkNullOrEmptyCamps();
        }

        private bool checkComboBox()
        {
            if (string.IsNullOrEmpty(comboBoxMatter.Text))
                return true;
            else
                return false;
        }

        private void comboBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQuestions.SelectedIndex > -1)
            {
                indice = comboBoxQuestions.SelectedIndex;
                tableQuestion = new DataTable();
                tableQuestion = generateQuestionsTable(materia);
                listaQuestao = new List<Questao>();
                listaQuestao = generateQuestionsList(tableQuestion);
                showQuestion(listaQuestao, indice);
                checkNullOrEmptyCamps();
            }
        }

        private void checkNullOrEmptyCamps()
        {
            if (!string.IsNullOrEmpty(richTxtBoxWordings.Text) && !string.IsNullOrEmpty(richTxtBoxSolution.Text) && !string.IsNullOrEmpty(richTxtBoxA.Text) && !string.IsNullOrEmpty(richTxtBoxB.Text) && !string.IsNullOrEmpty(richTxtBoxC.Text) && !string.IsNullOrEmpty(richTxtBoxD.Text) && !string.IsNullOrEmpty(richTxtBoxE.Text) && (radioA.Checked || radioB.Checked || radioC.Checked || radioD.Checked || radioE.Checked))
            {
                enableRegisterQuestionButton();
                enableUpdateQuestionButton();
            }

            else
            {
                disableRegisterQuestionButton();
                disableUpdateQuestionButton();
            }
        }

        private void enableRegisterQuestionButton()
        {
            btnRegisterQuestion.Enabled = true;
            btnRegisterQuestion.ForeColor = Color.Black;
        }

        private void disableRegisterQuestionButton()
        {
            btnRegisterQuestion.Enabled = false;
            btnRegisterQuestion.ForeColor = Color.Red;
        }

        private void enableUpdateQuestionButton()
        {
            btnUpdateQuestion.Enabled = true;
            btnUpdateQuestion.ForeColor = Color.Black;
        }

        private void disableUpdateQuestionButton()
        {
            btnUpdateQuestion.Enabled = false;
            btnUpdateQuestion.ForeColor = Color.Red;
        }

        private void richTxtBoxWordings_TextChanged(object sender, EventArgs e)
        {
            checkNullOrEmptyCamps();
        }

        private void richTxtBoxSolution_TextChanged(object sender, EventArgs e)
        {
            checkNullOrEmptyCamps();
        }

        private void richTxtBoxA_TextChanged(object sender, EventArgs e)
        {
            checkNullOrEmptyCamps();
        }

        private void richTxtBoxB_TextChanged(object sender, EventArgs e)
        {
            checkNullOrEmptyCamps();
        }

        private void richTxtBoxC_TextChanged(object sender, EventArgs e)
        {
            checkNullOrEmptyCamps();
        }

        private void richTxtBoxD_TextChanged(object sender, EventArgs e)
        {
            checkNullOrEmptyCamps();
        }

        private void richTxtBoxE_TextChanged(object sender, EventArgs e)
        {
            checkNullOrEmptyCamps();
        }

        private void updateQuestion()
        {
            int codigo = Convert.ToInt32(comboBoxQuestions.SelectedItem);
            string enunciado = richTxtBoxWordings.Text;
            string altA = richTxtBoxA.Text;
            string altB = richTxtBoxB.Text;
            string altC = richTxtBoxC.Text;
            string altD = richTxtBoxD.Text;
            string altE = richTxtBoxE.Text;
            char altCorreta = generateAnswer();
            string resolucao = richTxtBoxSolution.Text;
            int acertos = 0;
            int erros = 0;

            DataTable tableMateria = new DataTable();
            tableMateria = gerenciador.ConsultarBanco($"SELECT Cod_Materia FROM Materia WHERE Nome = '{materia}'");
            int codigoMateria = (int) tableMateria.Rows[0]["Cod_Materia"];

            Questao questao = new Questao(codigo, enunciado, altA, altB, altC, altD, altE, altCorreta, resolucao, acertos, erros);

            int rows = gerenciador.AtualizarBanco($"UPDATE Questao SET Enunciado = '{questao.enunciado}', AltA = '{questao.altA}', AltB = '{questao.altB}', AltC = '{questao.altC}', AltD = '{questao.altD}', AltE = '{questao.altE}', AltCorreta = '{questao.altCorreta}', Resolucao = '{questao.resolucao}', Cod_Materia = '{codigoMateria}', Acertos = {questao.acertos}, Erros = {questao.erros} WHERE Cod_Questao = {questao.codigo}");
            if (rows == 1)
                MessageBox.Show("Questão de código" + questao.codigo + " atualizada com sucesso!");
            else
                MessageBox.Show("Questão de código" + questao.codigo + " não atualizada! Verifique os dados e tente novamente");

            clearAll();
        }

        private void registerQuestion()
        {
            string enunciado = richTxtBoxWordings.Text;
            string altA = richTxtBoxA.Text;
            string altB = richTxtBoxB.Text;
            string altC = richTxtBoxC.Text;
            string altD = richTxtBoxD.Text;
            string altE = richTxtBoxE.Text;
            char altCorreta = generateAnswer();
            string resolucao = richTxtBoxSolution.Text;
            int acertos = 0;
            int erros = 0;

            DataTable tableMateria = new DataTable();
            tableMateria = gerenciador.ConsultarBanco($"SELECT Cod_Materia FROM Materia WHERE Nome = '{materia}'");
            int codigoMateria = (int)tableMateria.Rows[0]["Cod_Materia"];

            Questao questao = new Questao(enunciado, altA, altB, altC, altD, altE, altCorreta, resolucao, acertos, erros);

            int rows = gerenciador.AtualizarBanco($"INSERT INTO Questao (Enunciado, AltA, AltB, AltC, AltD, AltE, AltCorreta, Resolucao, Cod_Materia, Acertos, Erros) VALUES ('{questao.enunciado}', '{questao.altA}', '{questao.altB}', '{questao.altC}', '{questao.altD}', '{questao.altE}', '{questao.altCorreta}', '{questao.resolucao}', {codigoMateria}, {questao.acertos}, {questao.erros})");
            if (rows == 1)
                MessageBox.Show("Questão cadastrada com sucesso!");
            else
                MessageBox.Show("Questão não cadastrada! Verifique os dados e tente novamente");

            updateComboBoxQuestions();
            clearAll();
        }

        private void updateComboBoxQuestions()
        {
            comboBoxQuestions.Items.Clear();
            DataTable tableQuestoes = new DataTable();
            tableQuestoes = gerenciador.ConsultarBanco($"SELECT Cod_Questao FROM Questao Q INNER JOIN Materia M ON Q.Cod_Materia = M.Cod_Materia WHERE M.Nome = '{materia}'");

            for (int i = 0; i < tableQuestoes.Rows.Count; i++)
                comboBoxQuestions.Items.Add(tableQuestoes.Rows[i]["Cod_Questao"]);
        }

        private void clearAll()
        {
            richTxtBoxA.Text = string.Empty;
            richTxtBoxB.Text = string.Empty;
            richTxtBoxC.Text = string.Empty;
            richTxtBoxD.Text = string.Empty;
            richTxtBoxE.Text = string.Empty;
            richTxtBoxSolution.Text = string.Empty;
            richTxtBoxWordings.Text = string.Empty;
            comboBoxQuestions.SelectedIndex = -1;
            clearRadioButtons();
        }
    }
}
