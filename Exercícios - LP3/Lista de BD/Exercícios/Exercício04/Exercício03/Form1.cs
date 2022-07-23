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

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            try
            {
                updateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCustomSql_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlStatement = txtCustomSql.Text;

                    SqlCommand command = new SqlCommand(sqlStatement, connection);

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows == 1)
                    {
                        MessageBox.Show("Alterações realizadas com sucesso!");
                        updateList();
                    }

                    else
                        MessageBox.Show("Nenhuma alteração foi realizada!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateList()
        {
            lstNames.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlStatement = "SELECT Matricula, Aluno.Nome, Sexo, Turma.Nome FROM Aluno, Turma WHERE Aluno.Turma = Turma.Id";

                SqlCommand command = new SqlCommand(sqlStatement, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string dataRow = reader[0].ToString() + " - " +
                                         reader[1].ToString() + " - " +
                                         reader[2].ToString() + " - " +
                                         reader[3].ToString();

                        lstNames.Items.Add(dataRow);
                    }
                }
            }
        }
    }
}
