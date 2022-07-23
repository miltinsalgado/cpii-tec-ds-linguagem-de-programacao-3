using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginExemplo
{
    public partial class ImpostoForm : Form
    {
        DataBaseManager gerenciador = null;

        public ImpostoForm()
        {
            InitializeComponent();
            gerenciador = new DataBaseManager("ReceitaF");
        }

        private void ImpostoForm_Load(object sender, EventArgs e)
        {
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCodigoPacote_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnReter_Click(object sender, EventArgs e)
        {
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
        }
    }
}
