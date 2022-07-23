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

namespace Trabalho_2C
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Método clique para seguir para a tela de Resolução de Questões.
        private void btnResponderQuestoes_Click_1(object sender, EventArgs e)
        {
            CarregarTela(1);
            TelaDeResolucaoDeQuestoes tr = new TelaDeResolucaoDeQuestoes();
            tr.Show();
            this.Hide();
        }

        // Método clique para seguir para a tela de Cadastro de Questões.
        private void btnCadQuestoes_Click_1(object sender, EventArgs e)
        {
            CarregarTela(2);
            TelaDeLogin tl = new TelaDeLogin();
            tl.Show();
            this.Hide();
        }

        // Método para mostrar o progresso de carregamento das telas de Resolução de Cadastro de Questões.
        private void CarregarTela(int codigo)
        {
            for (int i = 0; i < 100; i++)
                pgrsBarMenu.Value++;

            if (codigo == 1)
                MessageBox.Show("Tela carregada com sucesso! \nClique no botão OK para prosseguir!", "TELA INICIAL (código 01)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (codigo == 2)
                MessageBox.Show("Tela carregada com sucesso! \nClique no botão OK para prosseguir!", "TELA INICIAL (código 02)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
