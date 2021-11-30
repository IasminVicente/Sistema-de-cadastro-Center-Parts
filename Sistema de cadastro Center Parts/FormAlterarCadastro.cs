using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_cadastro_Center_Parts
{
    public partial class FormAlterarCadastro : Form
    {
        public FormAlterarCadastro()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            FormListaCadastro formListaCadastro = new FormListaCadastro();
            formListaCadastro.ShowDialog();

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
    }
}
