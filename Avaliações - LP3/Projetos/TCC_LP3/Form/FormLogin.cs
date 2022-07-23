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

namespace TCC_LP3.Forms
{
    public partial class FormLogin : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        DataBaseManager gerenciador = new DataBaseManager("DataBase");
        DataTable tableUsuario = new DataTable();
        Usuario usuario = null;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword.UseSystemPasswordChar == true)
            {
                btnShowPassword.BackgroundImage = TCC_LP3.Properties.Resources.hiddeneye_password;
                txtBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnShowPassword.BackgroundImage = TCC_LP3.Properties.Resources.eye_password;
                txtBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChangePassword FormCP = new FormChangePassword();
            FormCP.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DataCheck())
            {
                string nome = txtBoxUser.Text;
                string senha = txtBoxPassword.Text;
                usuario = new Usuario(nome, senha);
                Login(usuario);
            }
            else
                MessageBox.Show("Usuário não encontrado no sistema! Verifique os dados inseridos e tente novamente ou cadastre-se");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (DataCheck())
            {
                string nome = txtBoxUser.Text;
                string senha = txtBoxPassword.Text;
                Usuario.Papel papel = Usuario.Papel.Padrao;
                papel = checkFunction();
                usuario = new Usuario(nome, senha, papel);
                SignUp(usuario);
            }
            else
                MessageBox.Show("Preencha todos os campos!");
        }

        private bool DataCheck()
        {
            if (string.IsNullOrEmpty(txtBoxUser.Text) || string.IsNullOrEmpty(txtBoxPassword.Text))
                return false;
            else
                return true;
        }

        private void SignUp(Usuario usuario)
        {
            tableUsuario = gerenciador.ConsultarBanco($"SELECT COUNT(*) FROM Usuario WHERE Nome = '{usuario.nome}'");
            int resultado = (int) tableUsuario.Rows[0][0];

            if (resultado != 0)
                MessageBox.Show("Usuário já cadastrado no sistema! Entre com seu login e senha!");
            else
            {
                int rows = gerenciador.AtualizarBanco($"INSERT INTO Usuario (Nome, Senha, Papel) VALUES ('{usuario.nome}', '{usuario.senha}', {Convert.ToInt32((usuario.papel))})");
                if (rows != -1)
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                else
                    MessageBox.Show("Usuário não cadatrado!");
            }
        }

        private void Login(Usuario usuario)
        {
            gerenciador = new DataBaseManager("DataBase");
            tableUsuario = gerenciador.ConsultarBanco($"SELECT COUNT(*) FROM Usuario WHERE Nome = '{usuario.nome}' AND Senha = '{usuario.senha}'");
            int resultado = (int) tableUsuario.Rows[0][0];

            if (resultado == 1)
            {
                MessageBox.Show("Login realizado com sucesso!");
                using (FormMenu FormM = new FormMenu(usuario))
                {
                    FormM.ShowDialog();
                }
                this.Hide();
            }
            else
                MessageBox.Show("Usuário não cadatrado!");
        }

        private Usuario.Papel checkFunction()
        {
            Usuario.Papel papel = Usuario.Papel.Padrao;
            if (radioAdmin.Checked)
                papel = Usuario.Papel.Administrador;
            if (radioPattern.Checked)
                papel = Usuario.Papel.Padrao;

            return papel;
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }

        private void checkPassword()
        {
            btnLogin.Enabled = false;
            btnSignUp.Enabled = false;
            lblLogin.ForeColor = Color.Gray;
            lblSignUp.ForeColor = Color.Gray;

            if (txtBoxPassword.Text.Length < 6)
            {
                lblPasswordError.Visible = true;
                lblPasswordError.Text = "AS SENHAS PRECISAM TER NO MÍNIMO 6 \nE NO MÁXIMO 8 DÍGITOS";
            }
            else
            {
                btnLogin.Enabled = true;
                btnSignUp.Enabled = true;
                lblLogin.ForeColor = Color.Black;
                lblSignUp.ForeColor = Color.Black;
                lblPasswordError.Visible = false;
            }
        }

    }
}
