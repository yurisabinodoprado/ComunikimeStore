using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunikimeStore
{
    class LoadingComboBox
    {
        public void Carregar(ComboBox cb_produtos)
        {
            //Conectando o BD
            MySqlConnection Conexao = new MySqlConnection("server = " + Constantes.Kserver + ";" + "port= " + Constantes.kport + ";" + "database=" + Constantes.Kdatabase + ";" + "uid =" + Constantes.Kuid + ";" + "pwd = ");

            //Comando de busca de dados
            MySqlCommand comando = new MySqlCommand("SELECT * from " + Constantes.Ktabela, Conexao);

            // Buscar dados e atualizar os dados da grid
            try
            {
                Conexao.Open(); 
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                comando.ExecuteNonQuery();

                DataTable tabela_temporaria = new DataTable();
                da.Fill(tabela_temporaria);

                
                DataRow row = tabela_temporaria.NewRow();
                tabela_temporaria.Rows.InsertAt(row, 0);
                cb_produtos.DataSource = tabela_temporaria;
                cb_produtos.ValueMember = "id_produto";
                cb_produtos.DisplayMember = "descricao";

                comando.ExecuteNonQuery();

                Conexao.Close();
            }

            //Caso haja um erro no procedimento: retornar mensagem de erro
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado");
            }
        }

    }
    
}
