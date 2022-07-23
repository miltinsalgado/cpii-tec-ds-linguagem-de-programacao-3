using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_LP3.Forms
{
    public partial class FormSelectMatterSimulated : Form
    {
        DataBaseManager gerenciador = new DataBaseManager("DataBase");
        DataTable tableQuestion = new DataTable();
        List<Questao> listaQuestao = new List<Questao>();
        Usuario usuario = null;

        public FormSelectMatterSimulated(Usuario usuarioLogado)
        {
            usuario = usuarioLogado;
            InitializeComponent();

            DataTable tableMateria = new DataTable();
            tableMateria = gerenciador.ConsultarBanco($"SELECT Nome FROM Materia");

            for (int i = 0; i < tableMateria.Rows.Count; i++)
                comboBoxMatter.Items.Add(tableMateria.Rows[i]["Nome"]);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (comboBoxMatter.SelectedIndex >= 0)
            {
                string materia = comboBoxMatter.SelectedItem.ToString();
                tableQuestion = gerenciador.ConsultarBanco($"SELECT Cod_Questao, Enunciado, AltA, AltB, AltC, AltD, AltE, AltCorreta, Resolucao, Q.Cod_Materia, Acertos, Erros FROM Questao Q INNER JOIN Materia M ON Q.Cod_Materia = M.Cod_Materia WHERE M.Nome = '{materia}' ORDER BY NEWID()");

                if(tableQuestion.Rows.Count < 10)
                    MessageBox.Show("Quantidade de questões de " + materia + " insuficientes para realização do simulado!");
                
                else
                {
                    using (FormMakeSimulated FormMS = new FormMakeSimulated(materia, usuario))
                        FormMS.ShowDialog();
                    this.Hide();
                }
                
            }
            else
                MessageBox.Show("Selecione uma matéria para começar o simulado!");        
        }
    }
}
