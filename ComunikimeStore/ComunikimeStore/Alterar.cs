using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunikimeStore
{
    public class Alterar
    {
        public void Alter(TextBox txt_categoria, TextBox txt_descricao, TextBox txt_marca, TextBox txt_qtd, TextBox txt_id)
        {

            //Iniciar Conexão
            MySqlConnection Conexao = new MySqlConnection("server = " + Constantes.Kserver + ";" + "port= " + Constantes.kport + ";" + "database=" + Constantes.Kdatabase + ";" + "uid =" + Constantes.Kuid + ";" + "pwd = ");

            //Comando SQL para alterar dados no banco
            MySqlCommand comando = new MySqlCommand("UPDATE produtos SET categoria=@p1, descricao=@p2,marca=@p3, quantidade=@p4 WHERE ID_PRODUTO=@p5", Conexao);


            //Validação de campos String
            if (String.IsNullOrEmpty(txt_categoria.Text) || String.IsNullOrEmpty(txt_descricao.Text) || String.IsNullOrEmpty(txt_marca.Text))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //Validação do processo e do campo Quantidade e ID_PRODUTO
                try
                {
                    comando.Parameters.AddWithValue("p1", txt_categoria.Text);
                    comando.Parameters.AddWithValue("p2", txt_descricao.Text);
                    comando.Parameters.AddWithValue("p3", txt_marca.Text);
                    comando.Parameters.AddWithValue("p4", Convert.ToInt32(txt_qtd.Text));
                    comando.Parameters.AddWithValue("p5", Convert.ToInt32(txt_id.Text));
                    Conexao.Open();
                    comando.ExecuteNonQuery();
                    Conexao.Close();
                    MessageBox.Show("Dados alterados com sucesso");
                }
                catch
                {
                    MessageBox.Show("Use Quantidade/ID válidos");
                }
                
            }
        }
    }
}
