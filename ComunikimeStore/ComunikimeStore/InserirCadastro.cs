using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunikimeStore
{
    public class Inserir
    {
        public void insert(TextBox txt_categoria, TextBox txt_descricao, TextBox txt_marca, TextBox txt_qtd)
        {

            //Iniciar Conexão
            MySqlConnection Conexao = new MySqlConnection("server = " + Constantes.Kserver + ";" + "port= " + Constantes.kport + ";" + "database=" + Constantes.Kdatabase + ";" + "uid =" + Constantes.Kuid + ";" + "pwd = ");

            //Comando SQL para inserir dados no banco
            MySqlCommand comando = new MySqlCommand("INSERT into " + Constantes.Ktabela + "(" + Constantes.Kcampo1 +","+ Constantes.Kcampo2 + "," + Constantes.Kcampo3 + "," + Constantes.Kcampo4 + ")" + "VALUES (@p1, @p2, @p3, @p4)", Conexao);

            //Validação de campos String
            if (String.IsNullOrEmpty(txt_categoria.Text) || String.IsNullOrEmpty(txt_descricao.Text) || String.IsNullOrEmpty(txt_marca.Text))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //Validação do processo e do campo Quantidade
                try
                {
                    comando.Parameters.AddWithValue("p1", txt_categoria.Text);
                    comando.Parameters.AddWithValue("p2", txt_descricao.Text);
                    comando.Parameters.AddWithValue("p3", txt_marca.Text);
                    comando.Parameters.AddWithValue("p4", Convert.ToInt32(txt_qtd.Text));
                    Conexao.Open();
                    comando.ExecuteNonQuery();
                    Conexao.Close();
                    MessageBox.Show("Dados cadastrados com sucesso");
                }
                catch
                {
                    MessageBox.Show("Digite uma quantidade válida");
                }
            }
        }
    }
}
