
namespace ComunikimeStore
{
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ven = new System.Windows.Forms.Label();
            this.lbl_das = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.GridVendas = new System.Windows.Forms.DataGridView();
            this.btn_autalizar = new System.Windows.Forms.Button();
            this.lbl_nome_cliente = new System.Windows.Forms.Label();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.txt_id_delete = new System.Windows.Forms.TextBox();
            this.lbl_id_deletar = new System.Windows.Forms.Label();
            this.lbl_tar = new System.Windows.Forms.Label();
            this.lbl_dele = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ven
            // 
            this.lbl_ven.AutoSize = true;
            this.lbl_ven.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ven.ForeColor = System.Drawing.Color.Red;
            this.lbl_ven.Location = new System.Drawing.Point(401, 51);
            this.lbl_ven.Name = "lbl_ven";
            this.lbl_ven.Size = new System.Drawing.Size(78, 38);
            this.lbl_ven.TabIndex = 2;
            this.lbl_ven.Text = "Ven";
            // 
            // lbl_das
            // 
            this.lbl_das.AutoSize = true;
            this.lbl_das.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_das.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_das.Location = new System.Drawing.Point(470, 51);
            this.lbl_das.Name = "lbl_das";
            this.lbl_das.Size = new System.Drawing.Size(79, 38);
            this.lbl_das.TabIndex = 3;
            this.lbl_das.Text = "Das";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.Black;
            this.btn_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(647, 244);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(193, 53);
            this.btn_confirmar.TabIndex = 10;
            this.btn_confirmar.Text = "Confirmar Venda";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Black;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Image = global::ComunikimeStore.Properties.Resources.back1;
            this.btn_back.Location = new System.Drawing.Point(22, 22);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(43, 40);
            this.btn_back.TabIndex = 1;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(92, 163);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(359, 21);
            this.comboBoxProduto.TabIndex = 11;
            this.comboBoxProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduto_SelectedIndexChanged);
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(567, 164);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(273, 20);
            this.txt_qtd.TabIndex = 12;
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.BackColor = System.Drawing.Color.Black;
            this.lbl_qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtd.ForeColor = System.Drawing.Color.White;
            this.lbl_qtd.Location = new System.Drawing.Point(563, 116);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(118, 24);
            this.lbl_qtd.TabIndex = 13;
            this.lbl_qtd.Text = "Quantidade";
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.BackColor = System.Drawing.Color.Black;
            this.lbl_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produto.ForeColor = System.Drawing.Color.White;
            this.lbl_produto.Location = new System.Drawing.Point(88, 116);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(83, 24);
            this.lbl_produto.TabIndex = 14;
            this.lbl_produto.Text = "Produto";
            // 
            // GridVendas
            // 
            this.GridVendas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVendas.Location = new System.Drawing.Point(92, 339);
            this.GridVendas.Name = "GridVendas";
            this.GridVendas.Size = new System.Drawing.Size(783, 301);
            this.GridVendas.TabIndex = 15;
            // 
            // btn_autalizar
            // 
            this.btn_autalizar.BackColor = System.Drawing.Color.Black;
            this.btn_autalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_autalizar.Image = global::ComunikimeStore.Properties.Resources.update2;
            this.btn_autalizar.Location = new System.Drawing.Point(894, 566);
            this.btn_autalizar.Name = "btn_autalizar";
            this.btn_autalizar.Size = new System.Drawing.Size(116, 74);
            this.btn_autalizar.TabIndex = 16;
            this.btn_autalizar.UseVisualStyleBackColor = false;
            this.btn_autalizar.Click += new System.EventHandler(this.btn_autalizar_Click_1);
            // 
            // lbl_nome_cliente
            // 
            this.lbl_nome_cliente.AutoSize = true;
            this.lbl_nome_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_cliente.ForeColor = System.Drawing.Color.White;
            this.lbl_nome_cliente.Location = new System.Drawing.Point(88, 220);
            this.lbl_nome_cliente.Name = "lbl_nome_cliente";
            this.lbl_nome_cliente.Size = new System.Drawing.Size(167, 24);
            this.lbl_nome_cliente.TabIndex = 17;
            this.lbl_nome_cliente.Text = "Nome do Cliente";
            this.lbl_nome_cliente.Click += new System.EventHandler(this.lbl_nome_cliente_Click);
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Location = new System.Drawing.Point(91, 262);
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(359, 20);
            this.txt_nome_cliente.TabIndex = 18;
            this.txt_nome_cliente.TextChanged += new System.EventHandler(this.txt_nome_cliente_TextChanged);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Black;
            this.btn_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Location = new System.Drawing.Point(180, 844);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(97, 52);
            this.btn_deletar.TabIndex = 37;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // txt_id_delete
            // 
            this.txt_id_delete.Location = new System.Drawing.Point(91, 802);
            this.txt_id_delete.Name = "txt_id_delete";
            this.txt_id_delete.Size = new System.Drawing.Size(263, 20);
            this.txt_id_delete.TabIndex = 36;
            // 
            // lbl_id_deletar
            // 
            this.lbl_id_deletar.AutoSize = true;
            this.lbl_id_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_deletar.ForeColor = System.Drawing.Color.White;
            this.lbl_id_deletar.Location = new System.Drawing.Point(87, 756);
            this.lbl_id_deletar.Name = "lbl_id_deletar";
            this.lbl_id_deletar.Size = new System.Drawing.Size(263, 24);
            this.lbl_id_deletar.TabIndex = 35;
            this.lbl_id_deletar.Text = "ID da Venda a ser deletada";
            this.lbl_id_deletar.Click += new System.EventHandler(this.lbl_id_deletar_Click);
            // 
            // lbl_tar
            // 
            this.lbl_tar.AutoSize = true;
            this.lbl_tar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_tar.Location = new System.Drawing.Point(224, 704);
            this.lbl_tar.Name = "lbl_tar";
            this.lbl_tar.Size = new System.Drawing.Size(69, 38);
            this.lbl_tar.TabIndex = 34;
            this.lbl_tar.Text = "Tar";
            // 
            // lbl_dele
            // 
            this.lbl_dele.AutoSize = true;
            this.lbl_dele.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dele.ForeColor = System.Drawing.Color.Red;
            this.lbl_dele.Location = new System.Drawing.Point(143, 704);
            this.lbl_dele.Name = "lbl_dele";
            this.lbl_dele.Size = new System.Drawing.Size(88, 38);
            this.lbl_dele.TabIndex = 33;
            this.lbl_dele.Text = "Dele";
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1011, 940);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.txt_id_delete);
            this.Controls.Add(this.lbl_id_deletar);
            this.Controls.Add(this.lbl_tar);
            this.Controls.Add(this.lbl_dele);
            this.Controls.Add(this.txt_nome_cliente);
            this.Controls.Add(this.lbl_nome_cliente);
            this.Controls.Add(this.btn_autalizar);
            this.Controls.Add(this.GridVendas);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.comboBoxProduto);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_das);
            this.Controls.Add(this.lbl_ven);
            this.Controls.Add(this.btn_back);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Vendas:.";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_ven;
        private System.Windows.Forms.Label lbl_das;
        private System.Windows.Forms.Button btn_confirmar;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.DataGridView GridVendas;
        private System.Windows.Forms.Button btn_autalizar;
        private System.Windows.Forms.Label lbl_nome_cliente;
        private System.Windows.Forms.TextBox txt_nome_cliente;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.TextBox txt_id_delete;
        private System.Windows.Forms.Label lbl_id_deletar;
        private System.Windows.Forms.Label lbl_tar;
        private System.Windows.Forms.Label lbl_dele;
    }
}