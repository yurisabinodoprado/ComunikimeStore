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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();

            //Carrega a grid ao inicilizar o Formulário
            carregar_grid();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Retorno ao formulário Menu
            this.Hide();
            Menu m = new Menu();
            m.ShowDialog();
            this.Close();
        }

        private void carregar_grid()
        {
            AddGridEstoque ag = new AddGridEstoque();
            ag.add(GridEstoque);
        }

        private void lbl_que_Click(object sender, EventArgs e)
        {

        }

        private void lbl_esto_Click(object sender, EventArgs e)
        {

        }

        private void Estoque_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Carregar o Fomulário de cadastro de produtos
            this.Hide();
            Cadastrar c = new Cadastrar();
            c.ShowDialog();
            this.Close();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {

        }

        private void GridEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_autalizar_Click(object sender, EventArgs e)
        {
            //Carregando a grid
            carregar_grid();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_produtos_Click(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click_1(object sender, EventArgs e)
        {
            //Alterar dados no Banco
            Alterar a = new Alterar();
            a.Alter(txt_categoria_alterar, txt_descricao_alterar, txt_marca_alterar, txt_quantidade_alterar, txt_id_alterar);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridEstoque_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_limpar_dados_Click(object sender, EventArgs e)
        {
            //Limpar as TextBoxs
            Limpar lp = new Limpar();
            lp.limpar(txt_categoria_alterar);
            lp.limpar(txt_descricao_alterar);
            lp.limpar(txt_id_alterar);
            lp.limpar(txt_marca_alterar);
            lp.limpar(txt_quantidade_alterar);
        }

        private void btn_deletar_Click_1(object sender, EventArgs e)
        {
            //Deletar dado do Banco
            Deletar d = new Deletar();
            d.del(txt_id_delete);
        }

        private void txt_id_delete_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
