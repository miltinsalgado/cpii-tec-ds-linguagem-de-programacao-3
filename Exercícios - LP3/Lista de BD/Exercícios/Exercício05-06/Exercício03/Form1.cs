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
            // Letra (a) (FEITO)
            UpdateLstStudents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Letra (b) (FEITO)
            UpdateCmbClass();
        }

        private void numRegistry_ValueChanged(object sender, EventArgs e)
        {
            // Letra (c) (TO DO)
            UpdateStudentInfos();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            // Letra (d) (TO DO)
            EditStudent();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            // Letra (e) (TO DO)
            DeleteStudent();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            // Letra (f) (TO DO)
            InsertNewStudent();
        }

        private void UpdateLstStudents()
        {
            lstNames.Items.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlStatement = "SELECT * FROM Aluno, Turma WHERE Aluno.Turma = Turma.Id";

                    SqlCommand command = new SqlCommand(sqlStatement, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string dataRow = reader["Matricula"].ToString() + " - " +
                                             reader["Nome"].ToString() + " - " +
                                             reader["Sexo"].ToString() + " - " +
                                             reader["Descricao"].ToString();

                            lstNames.Items.Add(dataRow);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCmbClass()
        {
            cmbClass.Items.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlStatement = "SELECT Descricao FROM Turma";

                    SqlCommand command = new SqlCommand(sqlStatement, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            cmbClass.Items.Add(reader["Descricao"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateStudentInfos()
        {
        }

        private void EditStudent()
        {
        }

        private void InsertNewStudent()
        {
        }

        private void DeleteStudent()
        {
        }
    }
}
