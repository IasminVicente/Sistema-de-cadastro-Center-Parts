using System;
using MySqlConnector;
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
    public partial class FormCadastrarLoginFuncionario : Form
    {
        public FormCadastrarLoginFuncionario()
        {
            InitializeComponent();
            TxtNomeUsuarioFuncionario.Select();

        }

        private void txtcadastrar_Click(object sender, EventArgs e)
        {
            string conStr = "server=127.0.0.1;uid=root;database=bd_centerparts;SslMode=none";
            MySqlConnection minhaConexao = new MySqlConnection(conStr);
            try
            {
                minhaConexao.Open();
                MySqlCommand objCommand = new MySqlCommand();
                objCommand.Connection = minhaConexao;
               

                if (TxtID.Text == "") 
                {
                    objCommand.CommandText =
                        "INSERT INTO usuario ( usuario, email, senha ) VALUES ( @usuario, @email, @senha  )";

                    objCommand.Parameters.AddWithValue("@usuario", TxtNomeUsuarioFuncionario.Text);
                    objCommand.Parameters.AddWithValue("@email", TxtEmailFuncionario.Text);
                    objCommand.Parameters.AddWithValue("@senha", TxtSenhaFuncionario.Text);
                }
                else   
                {
                    objCommand.CommandText =
                       "UPDATE funcionario set usuario = @usuario, email = @email, senha = @senha " +
                       "where id_funcionario = @id_funcionario";

                    objCommand.Parameters.AddWithValue("@usuario", TxtNomeUsuarioFuncionario.Text);
                    objCommand.Parameters.AddWithValue("@email", TxtEmailFuncionario.Text);
                    objCommand.Parameters.AddWithValue("@senha", TxtSenhaFuncionario.Text);
                    objCommand.Parameters.AddWithValue("@id_funcionario", TxtID.Text);
                }

                objCommand.ExecuteNonQuery();

                TxtNomeUsuarioFuncionario.Text = "";
                TxtEmailFuncionario.Text = "";
                TxtSenhaFuncionario.Text = "";
                TxtID.Text = "";

                MessageBox.Show("Operação realizada com Sucesso !");
            }
            catch (Exception erro) 
            {
                MessageBox.Show("Erro na operação.");
            }
            finally 
            {
                minhaConexao.Close();
                minhaConexao.Dispose();
            }
        }
       
        private void txtEmailFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastrarLoginFuncionario_Load(object sender, EventArgs e)
        {
        }

        private void TxtSenhaFuncionario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
