using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Trabalho_2C
{
    public partial class TelaDeLogin : Form
    {
        string diretorioAtual;

        public TelaDeLogin()
        {
            InitializeComponent();

            diretorioAtual = Directory.GetCurrentDirectory();
            diretorioAtual += @"\Usuários\Usuários.txt";
        }

        // Importação de DLL para permitir a movimentação do formulário.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Método clique do botão para fechar o formulário.
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Método para minimizar o formulário.
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Método para acessar a página de Resolução.
        private void btnTelaResolucao_Click(object sender, EventArgs e)
        {
            TelaInicial f1 = new TelaInicial();
            f1.Show();
            this.Hide();
        }

        // Método clique do botão Entrar, que verifica se os dados estão corretos para encaminhar o usuário para a Tela de Adição de Questões.
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            List<string> arquivo = new List<string>();
            using (StreamReader leitor = new StreamReader(diretorioAtual))
                while (!leitor.EndOfStream)
                    arquivo.Add(leitor.ReadLine());

            bool achamo = false;

            for (int i = 0; i < arquivo.Count; i++)
            {
                if (arquivo[i] != "============================")
                {
                    if ((arquivo[i] == txtboxUsuario.Text) && (arquivo[i + 1] == txtboxSenha.Text))
                    {
                        TelaDeAdicaoDeQuestoes f2 = new TelaDeAdicaoDeQuestoes();
                        f2.Show();
                        this.Hide();
                        achamo = true;
                        break;
                    }
                }
            }
            if (achamo == false)
            {
                btnEntrar.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
                MessageBox.Show("Usuário e/ou Senha incorretos! \nPor favor, digite novamente!", "TELA DE CADASTRO DE USUÁRIOS (código 01)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método clique do botão Cadastrar, que verifica se os dados estão corretos para cadastrar o usuário para ter acesso à Tela de Adição de Questões.
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(txtboxUsuario.Text, txtboxSenha.Text);
            List<string> arquivo = new List<string>();
            using (StreamReader leitor = new StreamReader(diretorioAtual))
            {
                while (!leitor.EndOfStream)
                    arquivo.Add(leitor.ReadLine());
            }
            bool achamo = false;

            if (String.IsNullOrEmpty(cad.usuario) || String.IsNullOrEmpty(cad.senha))
            {
                btnCadastrar.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
                MessageBox.Show("Campo(s) vazio(s) detectado(s)! \nPor favor, preencha todos os campos!", "TELA DE CADASTRO DE USUÁRIOS (código 02)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if ((cad.senha.Length < 3) && !String.IsNullOrEmpty(cad.senha))
            {
                btnCadastrar.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
                MessageBox.Show("Sua senha deve ter no minimo 3 caracteres! \nPor favor, digite novamente!", "TELA DE CADASTRO DE USUÁRIOS (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                for (int i = 0; i < arquivo.Count; i++)
                {
                    if (arquivo[i] != "============================")
                    {
                        if (arquivo[i] == txtboxUsuario.Text)
                        {
                            btnCadastrar.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
                            achamo = true;
                            MessageBox.Show("Nome de usuário já utilizado! \nPor favor, digite um nome de usuário diferente!", "TELA DE CADASTRO DE USUÁRIOS (código 04)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }

                if (achamo == false)
                {
                    btnCadastrar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
                    btnEntrar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
                    string CadUsers = diretorioAtual;
                    using (StreamWriter escritor = new StreamWriter(CadUsers, true))
                        escritor.WriteLine(cad.ToString());

                    txtboxUsuario.Text = String.Empty;
                    txtboxSenha.Text = String.Empty;
                    MessageBox.Show("Cadastro realizado com sucesso! \nClique no botão OK para prosseguir!", "TELA DE CADASTRO DE USUÁRIOS (código 05)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Método clique do botão Atualizar, que verifica se os dados estão corretos para atyalizar os dados do usuário.
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Cadastro newCad = new Cadastro(txtboxUsuarioNovaSenha.Text, txtboxNovaSenha.Text);
            string attSenha = diretorioAtual;
            List<string> arquivo = new List<string>();
            using (StreamReader leitor = new StreamReader(attSenha))
                while (!leitor.EndOfStream)
                    arquivo.Add(leitor.ReadLine());
            
            bool achamo = false;
            bool senhaIgual = false;

            if (String.IsNullOrEmpty(newCad.usuario) || String.IsNullOrEmpty(newCad.senha))
            {
                btnAtualizar.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
                MessageBox.Show("Campo(s) vazio(s) detectado(s)! \nPor favor, preencha todos os campos!", "TELA DE CADASTRO DE USUÁRIOS (código 02)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (newCad.senha.Length < 3 && !String.IsNullOrEmpty(newCad.senha))
            {
                btnAtualizar.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
                MessageBox.Show("Sua nova senha deve ter no minimo 3 caracteres! \nPor favor, digite novamente!", "TELA DE CADASTRO DE USUÁRIOS (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                for (int i = 0; i < arquivo.Count; i++)
                {
                    if (arquivo[i] != "============================")
                    {
                        if (arquivo[i] == newCad.usuario)
                        {
                            achamo = true;
                            if (arquivo[i + 1] == newCad.senha)
                            {
                                senhaIgual = true;
                                break;
                            }
                            arquivo[i + 1] = newCad.senha;
                            txtboxUsuarioNovaSenha.Text = String.Empty;
                            txtboxNovaSenha.Text = String.Empty;
                            break;
                        }
                    }
                }
            }

            if (((!String.IsNullOrEmpty(newCad.usuario) && !String.IsNullOrEmpty(newCad.senha)) && achamo == false) && newCad.senha.Length >= 3)
            {
                btnAtualizar.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
                MessageBox.Show("Usuário não encontrado \nPor favor, digite novamente!", "TELA DE CADASTRO DE USUÁRIOS (código 06)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (achamo == true && senhaIgual == false)
            {
                using (StreamWriter escritor = new StreamWriter(attSenha))
                    foreach (string linha in arquivo)
                        escritor.WriteLine(linha);
                
                btnAtualizar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
                MessageBox.Show("Senha alterada com sucesso! \nClique no botão OK para prosseguir!", "TELA DE CADASTRO DE USUÁRIO(código 05)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (achamo == true && senhaIgual == true)
            {
                btnAtualizar.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
                MessageBox.Show("A nova senha digitada é a mesma que a antiga! \nPor favor, digite uma senha diferente!", "TELA DE CADASTRO DE USUÁRIOS (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método clique do botão MostraSenha, para permitir a visualização da senha.
        private void btnMostraSenha_Click(object sender, EventArgs e)
        {
            if (txtboxSenha.UseSystemPasswordChar == true)
            {
                txtboxSenha.UseSystemPasswordChar = false;
                btnMostraSenha.BackgroundImage = Trabalho_2C.Properties.Resources.HiddenEye_password;
            }

            else
            {
                txtboxSenha.UseSystemPasswordChar = true;
                btnMostraSenha.BackgroundImage = Trabalho_2C.Properties.Resources.Eye_password;
            }
        }

        // Método clique do botão MostraNovaSenha, para permitir a visualização da nova senha.
        private void btnMostraNovaSenha_Click(object sender, EventArgs e)
        {
            if (txtboxNovaSenha.UseSystemPasswordChar == true)
            {
                txtboxNovaSenha.UseSystemPasswordChar = false;
                btnMostraNovaSenha.BackgroundImage = Trabalho_2C.Properties.Resources.HiddenEye_password;
            }

            else
            {
                txtboxNovaSenha.UseSystemPasswordChar = true;
                btnMostraNovaSenha.BackgroundImage = Trabalho_2C.Properties.Resources.Eye_password;
            }
        }

        // Método TextChanged que detecta alteração no texto da TextBox de Usuário.
        private void txtboxUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtboxUsuario.Text))
            {
                if (txtboxUsuario.Text.Contains(" "))
                {
                    MessageBox.Show("O sistema só aceita nomes de usuário sem espaço! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE USUÁRIOS (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxUsuario.Text = String.Empty;
                }
                if (txtboxUsuario.Text.Contains('\n'))
                {
                    MessageBox.Show("O sistema só aceita nomes de usuário sem quebra de linha! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE USUÁRIOS (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxUsuario.Text = String.Empty;
                }
            }
        }

        // Método TextChanged que detecta alteração no texto da TextBox de Senha.
        private void txtboxSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtboxSenha.Text.Contains(" "))
            {
                MessageBox.Show("O sistema só aceita senhas sem espaço! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE USUÁRIOS (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxSenha.Text = String.Empty;
            }
        }

        // Método TextChanged que detecta alteração no texto da TextBox de Usuario para cadastrar a Nova Senha.
        private void txtboxUsuarioNovaSenha_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtboxUsuarioNovaSenha.Text))
            {
                if (txtboxUsuarioNovaSenha.Text.Contains(" "))
                {
                    MessageBox.Show("O sistema só aceita nomes de usuário sem espaço! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE USUÁRIOS (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxUsuarioNovaSenha.Text = String.Empty;
                }

                if (txtboxUsuarioNovaSenha.Text.Contains('\n'))
                {
                    MessageBox.Show("O sistema só aceita nomes de usuário sem quebra de linha! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE USUÁRIOS (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxUsuarioNovaSenha.Text = String.Empty;
                }
            }
        }

        // Método TextChanged que detecta alteração no texto da TextBox da Nova Senha.
        private void txtboxNovaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtboxNovaSenha.Text.Contains(" "))
            {
                MessageBox.Show("O sistema só aceita senhas sem espaço! \nClique no botão OK para prosseguir!!", "TELA DE CADASTRO DE USUÁRIOS (código 03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxNovaSenha.Text = String.Empty;
            }
        }
    }
}
