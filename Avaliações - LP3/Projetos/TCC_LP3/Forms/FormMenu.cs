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
    public partial class FormMenu : Form
	{ 	
		private Form activeForm;
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		Usuario usuario = null;

		public FormMenu(Usuario usuarioLogado)
        {
            InitializeComponent();
			usuario = usuarioLogado;

			if (usuarioLogado.papel == Usuario.Papel.Padrao)
			{
				btnManageQuestions.ForeColor = Color.Gray;
				btnManageQuestions.Enabled = false;
			}
			else if (usuarioLogado.papel == Usuario.Papel.Administrador)
            {
				btnManageQuestions.ForeColor = Color.White;
				btnManageQuestions.Enabled = true;
			}
		}

		private void btnAnswerQuestions_Click(object sender, EventArgs e)
        {
			resetColor();
			btnAnswerQuestions.BackColor = Color.BlueViolet;
			OpenChildForm(new Forms.FormAnswerQuestons(), sender);
			lblTitle.Text = btnAnswerQuestions.Text;
		}

		private void btnMakeSimulated_Click(object sender, EventArgs e)
        {
			resetColor();
			btnMakeSimulated.BackColor = Color.BlueViolet;
			OpenChildForm(new Forms.FormSelectMatterSimulated(usuario), sender);
			lblTitle.Text = btnMakeSimulated.Text;
		}

		private void btnMenuUser_Click(object sender, EventArgs e)
        {
			resetColor();
			btnMenuUser.BackColor = Color.BlueViolet;
			OpenChildForm(new Forms.FormMenuUser(usuario), sender);
			lblTitle.Text = btnMenuUser.Text;
		}

		private void btnSeeHistory_Click(object sender, EventArgs e)
        {
			resetColor();
			btnSeeHistory.BackColor = Color.BlueViolet;
			OpenChildForm(new Forms.FormSeeRanking(), sender);
			lblTitle.Text = btnSeeHistory.Text;
		}

		private void btnManageQuestions_Click(object sender, EventArgs e)
		{
			resetColor();
			btnManageQuestions.BackColor = Color.BlueViolet;
			OpenChildForm(new Forms.FormMakeQuestion(), sender);
			lblTitle.Text = btnManageQuestions.Text;
		}

		private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

        private void btnClose_Click(object sender, EventArgs e)
        {
			this.Hide();
			FormLogin FormL = new FormLogin();
			FormL.ShowDialog();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
			WindowState = FormWindowState.Minimized;
        }

		private void resetColor()
        {
			btnAnswerQuestions.BackColor = Color.Transparent;
			btnMakeSimulated.BackColor = Color.Transparent;
			btnMenuUser.BackColor = Color.Transparent;
			btnSeeHistory.BackColor = Color.Transparent;
			btnManageQuestions.BackColor = Color.Transparent;
        }

		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Close();
			
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelDesktopPane.Controls.Add(childForm);
			this.panelDesktopPane.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
    }
}
