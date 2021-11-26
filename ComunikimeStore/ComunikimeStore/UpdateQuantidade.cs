using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunikimeStore
{
    class UpdateQuantidade
    {
        public void Update(TextBox txt_qtd, ComboBox cb_produto, TextBox txt_nome_cliente)
        {
            //Conectando o BD
            MySqlConnection Conexao = new MySqlConnection("server = " + Constantes.Kserver + ";" + "port= " + Constantes.kport + ";" + "database=" + Constantes.Kdatabase + ";" + "uid =" + Constantes.Kuid + ";" + "pwd = ");

            //Comando de busca de dados
            MySqlCommand comando = new MySqlCommand("UPDATE PRODUTOS SET quantidade = quantidade - @p1 where id_produto = @p2",Conexao);
            //Comando de subtração da quantidade no estoque conforme venda executada
            MySqlCommand comando2 = new MySqlCommand("Insert into vendas (id_produto, quantidade, nome_cliente) values (@p4, @p1, @p3)", Conexao);
            //Testando se campo txt_nome_cliente é vazio
            if (String.IsNullOrEmpty(txt_nome_cliente.Text))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            //Caso não for
            else
            {
                try
                {
                    comando.Parameters.AddWithValue("p1", Convert.ToInt32(txt_qtd.Text));
                    comando.Parameters.AddWithValue("p2", cb_produto.SelectedValue); //Seleciona o valor da ComboBox
                    comando2.Parameters.AddWithValue("p1", Convert.ToInt32(txt_qtd.Text));
                    comando2.Parameters.AddWithValue("p3", txt_nome_cliente.Text);
                    comando2.Parameters.AddWithValue("p4", cb_produto.SelectedValue);
                    Conexao.Open();
                    comando.ExecuteNonQuery();
                    comando2.ExecuteNonQuery();
                    Conexao.Close();
                    MessageBox.Show("Produto vendido com sucesso");
                }
                catch
                {
                    MessageBox.Show("Digite uma quantidade Válida");
                }

            }
        }
    }
}
