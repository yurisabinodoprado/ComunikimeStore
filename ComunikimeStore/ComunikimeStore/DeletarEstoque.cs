using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunikimeStore
{
   public class Deletar
    {
        public void del(TextBox txt_del)
        {
            //Abrindo conexão com o bd
            MySqlConnection Conexao = new MySqlConnection("server = " + Constantes.Kserver + ";" + "port= " + Constantes.kport + ";" + "database=" + Constantes.Kdatabase + ";" + "uid =" + Constantes.Kuid + ";" + "pwd = ");

            //Código sql para deletar dado no banco de dados
            MySqlCommand comando = new MySqlCommand("DELETE FROM produtos WHERE id_produto = @p0", Conexao);
            //Tentativa de deletar dados
            try
            {
                comando.Parameters.AddWithValue("p0", Convert.ToInt32(txt_del.Text));
                Conexao.Open();
                comando.ExecuteNonQuery();
                Conexao.Close();
                MessageBox.Show("Dado excluido com sucesso!");
            }

            //ID digitado por tipo de caractere não reconhecido
            catch
            {
                MessageBox.Show("Digite um ID válido");
            }
        }
           
    }
}
