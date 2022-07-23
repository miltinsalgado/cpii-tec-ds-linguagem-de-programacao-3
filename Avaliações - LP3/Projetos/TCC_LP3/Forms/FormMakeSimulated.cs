using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_LP3.Forms
{
    public partial class FormMakeSimulated : Form
    {
        DataBaseManager gerenciador = new DataBaseManager("DataBase");
        DataTable tableQuestion = new DataTable();
        List<Questao> listaQuestao = new List<Questao>();
        Usuario usuario = null;
        string materia = string.Empty;
        int indice = 0;
        int contAcertos = 0;
        int codigo = 0;
        int ticks = 600;

        public FormMakeSimulated(string materiaSelecionada, Usuario usuarioLogado)
        {
            materia = materiaSelecionada;
            usuario = usuarioLogado;
            DataTable tableUsuario = new DataTable();
            tableUsuario = gerenciador.ConsultarBanco($"SELECT Cod_Usuario FROM Usuario WHERE Nome = '{usuario.nome}'");
            codigo = (int) tableUsuario.Rows[0]["Cod_Usuario"];
            
            InitializeComponent();
            timer.Interval = 1000;
            timer.Start();

            lblMatter.Text = materia;
            DataTable tableImagens = new DataTable();

            tableImagens = gerenciador.ConsultarBanco($"SELECT Imagem FROM Materia WHERE Nome = '{materia}'");

            string imagemPath = tableImagens.Rows[0]["Imagem"].ToString();
            string path = $@"{Directory.GetCurrentDirectory()}\..\..\{imagemPath}";

            this.BackgroundImage = Image.FromFile(path);

            tableQuestion = new DataTable();
            tableQuestion = generateQuestionsTable(materia);
            
            listaQuestao = new List<Questao>();
            listaQuestao = generateQuestionsList(tableQuestion);
            showQuestion(listaQuestao, indice);
        }

        private void showQuestion(List<Questao> listaQuestao, int indice)
        {
            if (indice == 9)
                finishSimulated();
            else
            {
                richTxtBoxWordings.Text = listaQuestao[indice].enunciado;
                radioA.Text = listaQuestao[indice].altA;
                radioB.Text = listaQuestao[indice].altB;
                radioC.Text = listaQuestao[indice].altC;
                radioD.Text = listaQuestao[indice].altD;
                radioE.Text = listaQuestao[indice].altE;

                disableAnswerQuestionButton();
            }
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
            int cont = 0;
            foreach (DataRow row in tableQuestao.Rows)
            {
                if (cont == 9)
                    break;

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
                cont++;
            }

            return listQuestao;
        }

        private DataTable generateQuestionsTable(string materia)
        {
            DataTable tableQuestao = new DataTable();
            tableQuestao = gerenciador.ConsultarBanco($"SELECT Cod_Questao, Enunciado, AltA, AltB, AltC, AltD, AltE, AltCorreta, Resolucao, Q.Cod_Materia, Acertos, Erros FROM Questao Q INNER JOIN Materia M ON Q.Cod_Materia = M.Cod_Materia WHERE M.Nome = '{materia}' ORDER BY NEWID()");
            return tableQuestao;
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

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            bool acertou = checkAnswer(listaQuestao[indice]);
            DateTime today = DateTime.Today;
            string hoje = today.ToString();

            if (acertou)
            {
                listaQuestao[indice].acertos++;
                gerenciador.AtualizarBanco($"UPDATE Questao SET Acertos = {listaQuestao[indice].acertos} WHERE Cod_Questao = '{listaQuestao[indice].codigo}'");
                gerenciador.AtualizarBanco($"INSERT INTO Tentativa (Cod_Usuario, Cod_Questao, Acerto) VALUES ({codigo}, {listaQuestao[indice].codigo}, 1)");

                contAcertos++;
            }

            else
            {
                listaQuestao[indice].erros++;
                gerenciador.AtualizarBanco($"UPDATE Questao SET Erros = {listaQuestao[indice].erros} WHERE Cod_Questao = '{listaQuestao[indice].codigo}'");
                gerenciador.AtualizarBanco($"INSERT INTO Tentativa (Cod_Usuario, Cod_Questao, Acerto) VALUES ({codigo}, {listaQuestao[indice].codigo}, 0)");
            }

            if (indice == 9)
                finishSimulated();

            disableAnswerQuestionButton();
            indice++;
            showQuestion(listaQuestao, indice);
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

        private void timer_Tick(object sender, EventArgs e)
        {
            ticks--;
            lblTime.Text = ticks.ToString();
            if (ticks == 0)
                finishSimulated();
        }

        private void finishSimulated()
        {
            MessageBox.Show("Seu simulado chegou ao fim! Sua nota: " + contAcertos + "/10");
            this.Hide();
            FormSelectMatterSimulated FormSMS = new FormSelectMatterSimulated(usuario);
        }
    }
}
