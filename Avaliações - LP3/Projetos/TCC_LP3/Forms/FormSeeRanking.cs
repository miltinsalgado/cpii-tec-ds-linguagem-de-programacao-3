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


namespace TCC_LP3.Forms
{
    public partial class FormSeeRanking : Form
    {
        DataBaseManager gerenciador = new DataBaseManager("DataBase");
        List<string> listaUsuarios = new List<string>();

        public FormSeeRanking()
        {
            InitializeComponent();
        }

        private void FormSeeRanking_Load(object sender, EventArgs e)
        {
            DataTable tableUsuarios = new DataTable();
            tableUsuarios = gerenciador.ConsultarBanco("SELECT * FROM Usuario INNER JOIN Tentativa ON Usuario.Cod_Usuario = Tentativa.Cod_Usuario");
            string codigoUsuario = string.Empty;
            string nome = string.Empty;
            string codigoQuestao = string.Empty;
            string acerto = string.Empty;
            int cont = 0;

            foreach (DataRow row in tableUsuarios.Rows)
            {
                nome = tableUsuarios.Rows[cont]["Nome"].ToString();
                codigoUsuario = tableUsuarios.Rows[cont]["Cod_Usuario"].ToString();
                codigoQuestao = tableUsuarios.Rows[cont]["Cod_Questao"].ToString();
                if (Convert.ToInt32(tableUsuarios.Rows[cont]["Acerto"]) == 1)
                    acerto = "Acertou";
                else
                    acerto = "Errou";

                string texto = "Código do Usuário: " + codigoUsuario + " - Nome do Usuário: " + nome + " - Código da Questão: " + codigoQuestao + " - Status de Resposta: " + acerto;
                listRanking.Items.Add(texto);
                cont++;
            }
        }
    }
}
