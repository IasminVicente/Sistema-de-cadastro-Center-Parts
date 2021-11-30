using MySqlConnector;
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
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();


        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string conStr = "server=127.0.0.1;uid=root;database=bd_centerparts;SslMode=none";
            MySqlConnection minhaConexao = new MySqlConnection(conStr);
            try
            {
                minhaConexao.Open();
                MySqlCommand meuComando = new MySqlCommand();
                meuComando.Connection = minhaConexao;
                meuComando.CommandText = "SELECT * FROM funcionario WHERE EMAIL = @email AND SENHA = @senha ";

                meuComando.Parameters.AddWithValue("@email", txtEmail.Text);
                meuComando.Parameters.AddWithValue("@senha", txtSenha.Text);

                MySqlDataReader meuDataReader = meuComando.ExecuteReader();
               

                if (meuDataReader.HasRows == true)
                {
                    meuDataReader.Read();
                    MessageBox.Show("Seja bem vindo(a) " + meuDataReader["usuario"].ToString());
                    FormCadastro formcadastro = new FormCadastro();
                    formcadastro.Hide();
                    formcadastro.Show();
                    minhaConexao.Close();
                }
                else  
                {
                    MessageBox.Show("Usuário não encontrado.");
                    txtEmail.Text = "";
                    txtSenha.Text = "";
                    txtEmail.Select();
                }
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
    
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void txtCadastrase_Click(object sender, EventArgs e)
        {


            string conStr = "server=127.0.0.1;uid=root;database=bd_centerparts;SslMode=none";
            MySqlConnection minhaConexao = new MySqlConnection(conStr);

            FormCadastrarLoginFuncionario cadastrafuncionario = new FormCadastrarLoginFuncionario();
            cadastrafuncionario.Hide();
            cadastrafuncionario.Show();
            minhaConexao.Close();



        }
    }
}
