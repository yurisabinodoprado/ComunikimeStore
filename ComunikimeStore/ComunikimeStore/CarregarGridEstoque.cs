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
   public class AddGridEstoque
    {
        public void add(DataGridView dt)
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

                DataTable tabela_temporaria = new DataTable();

                da.Fill(tabela_temporaria);

                dt.DataSource = tabela_temporaria;

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
