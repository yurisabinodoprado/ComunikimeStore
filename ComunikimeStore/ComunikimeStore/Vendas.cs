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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
            //carregar combobox com a iniciação do fomulário
            LoadingComboBox lb = new LoadingComboBox();
            lb.Carregar(comboBoxProduto);
            //carregar GridVendas com a iniciação do formulário
            CarregarGridVendas cv = new CarregarGridVendas();
            cv.AddVendas(GridVendas);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Retorno ao formulário Menu
            this.Hide();
            Menu m = new Menu();
            m.ShowDialog();
            this.Close();
        }

        private void lbl_quantidade_Click(object sender, EventArgs e)
        {

        }

        private void Vendas_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            UpdateQuantidade uq = new UpdateQuantidade();
            uq.Update(txt_qtd, comboBoxProduto, txt_nome_cliente);
        }

        private void GridVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_autalizar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void lbl_produto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_autalizar_Click_1(object sender, EventArgs e)
        {
            //Atualiza as vendas
            CarregarGridVendas cv = new CarregarGridVendas();
            cv.AddVendas(GridVendas);
        }

        private void lbl_nome_cliente_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_id_deletar_Click(object sender, EventArgs e)
        {

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            //Comando de deletar dados da tabela vendas
            DeletarVendas dv = new DeletarVendas();
            dv.DelVendas(txt_id_delete);
        }
    }
}
