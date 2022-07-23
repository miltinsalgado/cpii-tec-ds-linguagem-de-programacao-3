using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Exercício03
{
    public partial class Form1 : Form
    {
        private string connectionString;

        public Form1()
        {
            string dataBasePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" + dataBasePath + @"Colegio.mdf';Integrated Security=True";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* TO-DO:
             * 
             * Assim que o formulário for carregado é necessário que a ComboBox da Turma
             * seja preenchida com todos os nomes de turmas possíveis.
             */
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            /* TO-DO:
             * 
             * Este método não é capaz de realizar o filtro de acordo com os controles
             * do formulário (ComboBox da Turma, Radio Button do Sexo do Aluno e 
             * TextBox da Inicial) 
             */

            lstNames.Items.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlStatement = "SELECT * FROM Aluno";

                    SqlCommand command = new SqlCommand(sqlStatement, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            lstNames.Items.Add(Convert.ToString(reader["Nome"]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
