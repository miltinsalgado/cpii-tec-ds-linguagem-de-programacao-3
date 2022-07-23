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
    public partial class FormMenuUser : Form
    {
        Usuario usuario = new Usuario();
        DataBaseManager gerenciador = new DataBaseManager("DataBase");
        public FormMenuUser(Usuario usuarioLogado)
        {
            usuario = usuarioLogado;
            InitializeComponent();
            DataTable tableUsuario = new DataTable();
            tableUsuario = gerenciador.ConsultarBanco($"SELECT * FROM Usuario WHERE Usuario.Nome = '{usuario.nome}'");
            lblName.Text = usuario.nome;
            lblCodigo_Usuario.Text = tableUsuario.Rows[0]["Cod_Usuario"].ToString();

            if (usuario.papel == Usuario.Papel.Administrador)
                lblPapel.Text = "Administrador";
            else
                lblPapel.Text = "Padrão";

            DataTable tableAcertos = new DataTable();
            tableAcertos = gerenciador.ConsultarBanco($"SELECT COUNT(*) FROM Tentativa WHERE Cod_Usuario = {tableUsuario.Rows[0]["Cod_Usuario"]} AND Acerto = 1");
            if (tableAcertos.Rows.Count <= 0)
                lblAcertos.Text = "0";
            else
            {
                int resultado = Convert.ToInt32(tableAcertos.Rows[0][0]);
                lblAcertos.Text = resultado.ToString();
            }   
        }
    }
}
