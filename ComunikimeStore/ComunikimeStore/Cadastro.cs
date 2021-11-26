using MySql.Data.MySqlClient;
using System;
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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void lbl_tro_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Volta para o formulário Estoque
            this.Hide();
            Estoque es = new Estoque();
            es.ShowDialog();
            this.Close();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {

            //Cadastrando dados no Banco
            Inserir i = new Inserir();
            i.insert(txt_categoria, txt_descricao, txt_marca, txt_quantidade);

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            //Limpando os campos
            Limpar lc = new Limpar();
            lc.limpar(txt_categoria);
            lc.limpar(txt_descricao);
            lc.limpar(txt_marca);
            lc.limpar(txt_quantidade);


        }

        public void txt_categoria_TextChanged(object sender, EventArgs e)
        {

        }

        public void txt_quantidade_TextChanged(object sender, EventArgs e)
        { 

        }

        public void txt_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        public void txt_marca_TextChanged(object sender, EventArgs e)
        {

        }
 
    }
}

