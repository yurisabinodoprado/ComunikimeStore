using System;
using System.Threading;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estoque sistema = new Estoque();
            sistema.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_slogan_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendas sistema = new Vendas();
            sistema.ShowDialog();
            this.Close();
        }

        private void lbl_vendas_Click(object sender, EventArgs e)
        {

        }
    }
}
