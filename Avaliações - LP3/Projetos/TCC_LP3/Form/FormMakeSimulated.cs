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
    public partial class FormMakeSimulated : Form
    {
        public FormMakeSimulated()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tabPage.SelectedTab = tabSimulated;
        }
    }
}
