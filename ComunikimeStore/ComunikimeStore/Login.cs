using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunikimeStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_me_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            //variáveis de armazenamento das informações

            String usuario = "";
            String senha = "";

            //conexão com o banco de dados

            MySqlConnection Conexao = new MySqlConnection("server = 127.0.0.1; port = 3306; database= estoque; uid = root; pwd = ");

            //Comando sql
            MySqlCommand comando = new MySqlCommand("SELECT usuario, senha from login where usuario = @parametro1 and senha = @parametro2", Conexao);

            //Preencher os parametros com as caixas de texto
            comando.Parameters.AddWithValue("parametro1", txt_usuario.Text);
            comando.Parameters.AddWithValue("parametro2", txt_senha.Text);

            //abrir coenxão
            Conexao.Open();

            //Obter dados do comando sql que será executado
            MySqlDataReader dados = comando.ExecuteReader();

            //Continuação
            while (dados.Read())
            {
                usuario = dados["usuario"].ToString();
                senha = dados["senha"].ToString();
            }

            //Fechar coneção
            Conexao.Close();

            //Se usuário ou senha inválido
            if (usuario == "")
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
            else
            {
                this.Hide();

                //criar Form

                Menu f = new Menu();

                //Abrir proxima tela
                f.ShowDialog();

                //fechar
                this.Close();


            }
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            txt_senha.PasswordChar = '*';
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
