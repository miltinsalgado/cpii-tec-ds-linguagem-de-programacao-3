using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_Pratico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader leitor = null;
            SqlConnection conexao = null;
            SqlCommand comando = null;

            try
            {
                string stringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\milto\Downloads\Desenvolvimento de Sistemas\Linguagem de Programação III\Projetos de Exemplo -  LPIII\Exemplo Pratico\Colegio.mdf';Integrated Security=True";
                conexao = new SqlConnection(stringDeConexao);
                conexao.Open();

                string consulta = "SELECT * FROM Aluno";
                comando = new SqlCommand(consulta, conexao);
                leitor = comando.ExecuteReader();

                while (leitor.Read())
                    listBoxAlunos.Items.Add(leitor["Nome"].ToString());
                
            }

            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

            finally
            {
                if (leitor != null)
                    leitor.Close();

                if (conexao != null)
                    conexao.Close();
            }
        }
    }
}
