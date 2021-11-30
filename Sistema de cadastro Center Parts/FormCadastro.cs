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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btConsultarCliente_Click(object sender, EventArgs e)
        {
            FormConsulta formConsulta = new FormConsulta();
            formConsulta.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
       
        }

        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            string conStr = "server=127.0.0.1;uid=root;database=bd_centerparts;SslMode=none";
            MySqlConnection minhaConexao = new MySqlConnection(conStr);
            try
            {
                minhaConexao.Open();
                MySqlCommand objCommand = new MySqlCommand();
                objCommand.Connection = minhaConexao;

            if (txtIdCliente.Text == "") 
            {
                objCommand.CommandText =
               "INSERT INTO cliente ( nome_cliente, email, telefone, endereço, cpf ) VALUES ( @nome_cliente, @email, @telefone, @endereço, @cpf  )";

                objCommand.Parameters.AddWithValue("@nome_cliente", txtNomeCliente.Text);
                objCommand.Parameters.AddWithValue("@email", txtEmailCliente.Text);
                objCommand.Parameters.AddWithValue("@telefone", txtTelefoneCliente.Text);
                objCommand.Parameters.AddWithValue("@endereço", txtEnderecoCliente.Text);
                objCommand.Parameters.AddWithValue("@cpf", txtCpfCliente.Text);
            }
            else   
            {
                objCommand.CommandText =
                   "UPDATE cliente set nome_cliente = @nome_cliente, email = @email, telefone = @telefone, endereço = @endereço, cpf = @cpf " +
                       "where id_cliente = @id_cliente";

                    objCommand.Parameters.AddWithValue("@nome_cliente", txtNomeCliente.Text);
                    objCommand.Parameters.AddWithValue("@email", txtEmailCliente.Text);
                    objCommand.Parameters.AddWithValue("@telefone", txtTelefoneCliente.Text);
                    objCommand.Parameters.AddWithValue("@endereço", txtEnderecoCliente.Text);
                    objCommand.Parameters.AddWithValue("@cpf", txtCpfCliente.Text);
                    objCommand.Parameters.AddWithValue("@id_cliente", txtIdCliente.Text);
            }
                objCommand.ExecuteNonQuery();

                txtNomeCliente.Text = "";
                txtEmailCliente.Text = "";
                txtTelefoneCliente.Text = "";
                txtEnderecoCliente.Text = "";
                txtCpfCliente.Text = "";
                txtIdCliente.Text = "";

                MessageBox.Show("Operação realizada com Sucesso !");
            }
            catch (Exception erro) // ocorre quando der RUIM !!
            {
                MessageBox.Show("Erro na operação.");
            }
            finally // sempre ocorre !!
            {
                minhaConexao.Close();
                minhaConexao.Dispose();
            }
        }
        
    }
}
