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
    public partial class FormChangePassword : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FormChangePassword()
        {
            InitializeComponent();
        }

        DataBaseManager gerenciador = new DataBaseManager("DataBase");
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin FormL = new FormLogin();
            FormL.ShowDialog();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            showPassword(1);
        }

        private void btnShowPassword2_Click(object sender, EventArgs e)
        {
            showPassword(2);
        }

        private void showPassword (int txtBoxCode)
        {
            if (txtBoxCode == 1)
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

            else
            {
                if (txtBoxPassword2.UseSystemPasswordChar == true)
                {
                    btnShowPassword2.BackgroundImage = TCC_LP3.Properties.Resources.hiddeneye_password;
                    txtBoxPassword2.UseSystemPasswordChar = false;
                }
                else
                {
                    btnShowPassword2.BackgroundImage = TCC_LP3.Properties.Resources.eye_password;
                    txtBoxPassword2.UseSystemPasswordChar = true;
                }
            }
        }

        private void txtBoxPassword2_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }

        private void checkPassword()
        {
            btnChangePassword.Enabled = false;
            lblChangePassword.ForeColor = Color.Gray;

            if (txtBoxPassword.Text.Length < 6 || txtBoxPassword2.Text.Length < 6)
            {
                lblPasswordError.Visible = true;
                lblPasswordError.Text = "AS SENHAS PRECISAM TER NO MÍNIMO 6 E NO MÁXIMO 8 DÍGITOS";
            }
            else
            {
                if (txtBoxPassword.Text != txtBoxPassword2.Text)
                {
                    lblPasswordError.Visible = true;
                    lblPasswordError.Text = "AS SENHAS NÃO COINCIDEM";
                }
                else
                {
                    lblPasswordError.Visible = false;
                    lblChangePassword.ForeColor = Color.Black;
                    btnChangePassword.Enabled = true;
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (DataCheck())
            {
                string nome = txtBoxUser.Text;
                string senha = txtBoxPassword.Text;

                Usuario usuario = new Usuario(nome, senha);
                ChangePassword(usuario);
            }
            else
                MessageBox.Show("Preencha todos os campos!");
        }

        private bool DataCheck()
        {
            if (string.IsNullOrEmpty(txtBoxUser.Text) || string.IsNullOrEmpty(txtBoxPassword.Text) || string.IsNullOrEmpty(txtBoxPassword2.Text))
                return false;
            else
                return true;
        }

        private void ChangePassword(Usuario usuario)
        {
            gerenciador = new DataBaseManager("DataBase");
            int rows = gerenciador.AtualizarBanco($"UPDATE Usuario SET Senha = '{usuario.senha}' WHERE Nome = '{usuario.nome}'");
            if (rows != -1)
                MessageBox.Show("Senha alterada com sucesso!");
            else
                MessageBox.Show("Usuário não encontrado! Verifique os dados inseridos e tente novamente ou cadastre-se");
        }
    }
}
