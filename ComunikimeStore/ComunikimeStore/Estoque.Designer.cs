
namespace ComunikimeStore
{
    partial class Estoque
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
            this.lbl_esto = new System.Windows.Forms.Label();
            this.lbl_que = new System.Windows.Forms.Label();
            this.lbl_cadastrar = new System.Windows.Forms.Label();
            this.lbl_produtos = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_autalizar = new System.Windows.Forms.Button();
            this.txt_id_alterar = new System.Windows.Forms.TextBox();
            this.txt_categoria_alterar = new System.Windows.Forms.TextBox();
            this.txt_marca_alterar = new System.Windows.Forms.TextBox();
            this.txt_descricao_alterar = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_quantidade_alterar = new System.Windows.Forms.TextBox();
            this.lbl_novos_dados = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_limpar_dados = new System.Windows.Forms.Button();
            this.lbl_alterar = new System.Windows.Forms.Label();
            this.lbl_dados = new System.Windows.Forms.Label();
            this.lbl_att = new System.Windows.Forms.Label();
            this.lbl_dele = new System.Windows.Forms.Label();
            this.lbl_tar = new System.Windows.Forms.Label();
            this.lbl_id_deletar = new System.Windows.Forms.Label();
            this.txt_id_delete = new System.Windows.Forms.TextBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.GridEstoque = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_esto
            // 
            this.lbl_esto.AutoSize = true;
            this.lbl_esto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_esto.ForeColor = System.Drawing.Color.Red;
            this.lbl_esto.Location = new System.Drawing.Point(567, 34);
            this.lbl_esto.Name = "lbl_esto";
            this.lbl_esto.Size = new System.Drawing.Size(87, 38);
            this.lbl_esto.TabIndex = 1;
            this.lbl_esto.Text = "Esto";
            this.lbl_esto.Click += new System.EventHandler(this.lbl_esto_Click);
            // 
            // lbl_que
            // 
            this.lbl_que.AutoSize = true;
            this.lbl_que.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_que.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_que.Location = new System.Drawing.Point(644, 34);
            this.lbl_que.Name = "lbl_que";
            this.lbl_que.Size = new System.Drawing.Size(82, 38);
            this.lbl_que.TabIndex = 2;
            this.lbl_que.Text = "Que";
            this.lbl_que.Click += new System.EventHandler(this.lbl_que_Click);
            // 
            // lbl_cadastrar
            // 
            this.lbl_cadastrar.AutoSize = true;
            this.lbl_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastrar.ForeColor = System.Drawing.Color.White;
            this.lbl_cadastrar.Location = new System.Drawing.Point(1238, 192);
            this.lbl_cadastrar.Name = "lbl_cadastrar";
            this.lbl_cadastrar.Size = new System.Drawing.Size(79, 20);
            this.lbl_cadastrar.TabIndex = 5;
            this.lbl_cadastrar.Text = "Cadastrar";
            // 
            // lbl_produtos
            // 
            this.lbl_produtos.AutoSize = true;
            this.lbl_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtos.ForeColor = System.Drawing.Color.White;
            this.lbl_produtos.Location = new System.Drawing.Point(1244, 212);
            this.lbl_produtos.Name = "lbl_produtos";
            this.lbl_produtos.Size = new System.Drawing.Size(73, 20);
            this.lbl_produtos.TabIndex = 6;
            this.lbl_produtos.Text = "Produtos";
            this.lbl_produtos.Click += new System.EventHandler(this.lbl_produtos_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Black;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Image = global::ComunikimeStore.Properties.Resources.icon_cadastrar_produtos1;
            this.btn_cadastrar.Location = new System.Drawing.Point(1227, 86);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(101, 103);
            this.btn_cadastrar.TabIndex = 3;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
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
            this.btn_back.TabIndex = 0;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_autalizar
            // 
            this.btn_autalizar.BackColor = System.Drawing.Color.Black;
            this.btn_autalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_autalizar.Image = global::ComunikimeStore.Properties.Resources.update2;
            this.btn_autalizar.Location = new System.Drawing.Point(1210, 350);
            this.btn_autalizar.Name = "btn_autalizar";
            this.btn_autalizar.Size = new System.Drawing.Size(116, 74);
            this.btn_autalizar.TabIndex = 11;
            this.btn_autalizar.UseVisualStyleBackColor = false;
            this.btn_autalizar.Click += new System.EventHandler(this.btn_autalizar_Click);
            // 
            // txt_id_alterar
            // 
            this.txt_id_alterar.Location = new System.Drawing.Point(150, 617);
            this.txt_id_alterar.Name = "txt_id_alterar";
            this.txt_id_alterar.Size = new System.Drawing.Size(257, 20);
            this.txt_id_alterar.TabIndex = 12;
            this.txt_id_alterar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_categoria_alterar
            // 
            this.txt_categoria_alterar.Location = new System.Drawing.Point(550, 647);
            this.txt_categoria_alterar.Name = "txt_categoria_alterar";
            this.txt_categoria_alterar.Size = new System.Drawing.Size(231, 20);
            this.txt_categoria_alterar.TabIndex = 13;
            // 
            // txt_marca_alterar
            // 
            this.txt_marca_alterar.Location = new System.Drawing.Point(550, 772);
            this.txt_marca_alterar.Name = "txt_marca_alterar";
            this.txt_marca_alterar.Size = new System.Drawing.Size(231, 20);
            this.txt_marca_alterar.TabIndex = 14;
            this.txt_marca_alterar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_descricao_alterar
            // 
            this.txt_descricao_alterar.Location = new System.Drawing.Point(550, 712);
            this.txt_descricao_alterar.Name = "txt_descricao_alterar";
            this.txt_descricao_alterar.Size = new System.Drawing.Size(231, 20);
            this.txt_descricao_alterar.TabIndex = 15;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(146, 580);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(261, 24);
            this.lbl_id.TabIndex = 16;
            this.lbl_id.Text = "ID do campo a ser alterado";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_categoria.Location = new System.Drawing.Point(547, 621);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(76, 16);
            this.lbl_categoria.TabIndex = 17;
            this.lbl_categoria.Text = "Categoria";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_descricao.Location = new System.Drawing.Point(547, 682);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(79, 16);
            this.lbl_descricao.TabIndex = 18;
            this.lbl_descricao.Text = "Descrição";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_marca.Location = new System.Drawing.Point(547, 747);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(51, 16);
            this.lbl_marca.TabIndex = 19;
            this.lbl_marca.Text = "Marca";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_quantidade.Location = new System.Drawing.Point(547, 819);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(88, 16);
            this.lbl_quantidade.TabIndex = 21;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // txt_quantidade_alterar
            // 
            this.txt_quantidade_alterar.Location = new System.Drawing.Point(550, 844);
            this.txt_quantidade_alterar.Name = "txt_quantidade_alterar";
            this.txt_quantidade_alterar.Size = new System.Drawing.Size(231, 20);
            this.txt_quantidade_alterar.TabIndex = 20;
            // 
            // lbl_novos_dados
            // 
            this.lbl_novos_dados.AutoSize = true;
            this.lbl_novos_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_novos_dados.ForeColor = System.Drawing.Color.White;
            this.lbl_novos_dados.Location = new System.Drawing.Point(547, 580);
            this.lbl_novos_dados.Name = "lbl_novos_dados";
            this.lbl_novos_dados.Size = new System.Drawing.Size(134, 24);
            this.lbl_novos_dados.TabIndex = 22;
            this.lbl_novos_dados.Text = "Novos Dados";
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Black;
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(131, 844);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(97, 52);
            this.btn_alterar.TabIndex = 23;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click_1);
            // 
            // btn_limpar_dados
            // 
            this.btn_limpar_dados.BackColor = System.Drawing.Color.Black;
            this.btn_limpar_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar_dados.ForeColor = System.Drawing.Color.White;
            this.btn_limpar_dados.Location = new System.Drawing.Point(312, 844);
            this.btn_limpar_dados.Name = "btn_limpar_dados";
            this.btn_limpar_dados.Size = new System.Drawing.Size(95, 52);
            this.btn_limpar_dados.TabIndex = 24;
            this.btn_limpar_dados.Text = "Limpar";
            this.btn_limpar_dados.UseVisualStyleBackColor = false;
            this.btn_limpar_dados.Click += new System.EventHandler(this.btn_limpar_dados_Click);
            // 
            // lbl_alterar
            // 
            this.lbl_alterar.AutoSize = true;
            this.lbl_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alterar.ForeColor = System.Drawing.Color.Red;
            this.lbl_alterar.Location = new System.Drawing.Point(402, 502);
            this.lbl_alterar.Name = "lbl_alterar";
            this.lbl_alterar.Size = new System.Drawing.Size(168, 38);
            this.lbl_alterar.TabIndex = 25;
            this.lbl_alterar.Text = "Alterar da";
            this.lbl_alterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_dados
            // 
            this.lbl_dados.AutoSize = true;
            this.lbl_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_dados.Location = new System.Drawing.Point(567, 502);
            this.lbl_dados.Name = "lbl_dados";
            this.lbl_dados.Size = new System.Drawing.Size(79, 38);
            this.lbl_dados.TabIndex = 26;
            this.lbl_dados.Text = "Dos";
            this.lbl_dados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_att
            // 
            this.lbl_att.AutoSize = true;
            this.lbl_att.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_att.Location = new System.Drawing.Point(1236, 437);
            this.lbl_att.Name = "lbl_att";
            this.lbl_att.Size = new System.Drawing.Size(81, 24);
            this.lbl_att.TabIndex = 27;
            this.lbl_att.Text = "Atualizar";
            // 
            // lbl_dele
            // 
            this.lbl_dele.AutoSize = true;
            this.lbl_dele.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dele.ForeColor = System.Drawing.Color.Red;
            this.lbl_dele.Location = new System.Drawing.Point(1052, 580);
            this.lbl_dele.Name = "lbl_dele";
            this.lbl_dele.Size = new System.Drawing.Size(88, 38);
            this.lbl_dele.TabIndex = 28;
            this.lbl_dele.Text = "Dele";
            // 
            // lbl_tar
            // 
            this.lbl_tar.AutoSize = true;
            this.lbl_tar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_tar.Location = new System.Drawing.Point(1133, 580);
            this.lbl_tar.Name = "lbl_tar";
            this.lbl_tar.Size = new System.Drawing.Size(69, 38);
            this.lbl_tar.TabIndex = 29;
            this.lbl_tar.Text = "Tar";
            // 
            // lbl_id_deletar
            // 
            this.lbl_id_deletar.AutoSize = true;
            this.lbl_id_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_deletar.ForeColor = System.Drawing.Color.White;
            this.lbl_id_deletar.Location = new System.Drawing.Point(1055, 675);
            this.lbl_id_deletar.Name = "lbl_id_deletar";
            this.lbl_id_deletar.Size = new System.Drawing.Size(267, 24);
            this.lbl_id_deletar.TabIndex = 30;
            this.lbl_id_deletar.Text = "ID do campo a ser deletado";
            // 
            // txt_id_delete
            // 
            this.txt_id_delete.Location = new System.Drawing.Point(1059, 712);
            this.txt_id_delete.Name = "txt_id_delete";
            this.txt_id_delete.Size = new System.Drawing.Size(263, 20);
            this.txt_id_delete.TabIndex = 31;
            this.txt_id_delete.TextChanged += new System.EventHandler(this.txt_id_delete_TextChanged);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Black;
            this.btn_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Location = new System.Drawing.Point(1140, 801);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(97, 52);
            this.btn_deletar.TabIndex = 32;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click_1);
            // 
            // GridEstoque
            // 
            this.GridEstoque.BackgroundColor = System.Drawing.Color.White;
            this.GridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEstoque.Location = new System.Drawing.Point(213, 86);
            this.GridEstoque.Name = "GridEstoque";
            this.GridEstoque.Size = new System.Drawing.Size(901, 363);
            this.GridEstoque.TabIndex = 33;
            this.GridEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEstoque_CellContentClick_1);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1392, 934);
            this.Controls.Add(this.GridEstoque);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.txt_id_delete);
            this.Controls.Add(this.lbl_id_deletar);
            this.Controls.Add(this.lbl_tar);
            this.Controls.Add(this.lbl_dele);
            this.Controls.Add(this.lbl_att);
            this.Controls.Add(this.lbl_dados);
            this.Controls.Add(this.lbl_alterar);
            this.Controls.Add(this.btn_limpar_dados);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.lbl_novos_dados);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.txt_quantidade_alterar);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_descricao_alterar);
            this.Controls.Add(this.txt_marca_alterar);
            this.Controls.Add(this.txt_categoria_alterar);
            this.Controls.Add(this.txt_id_alterar);
            this.Controls.Add(this.btn_autalizar);
            this.Controls.Add(this.lbl_produtos);
            this.Controls.Add(this.lbl_cadastrar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_que);
            this.Controls.Add(this.lbl_esto);
            this.Controls.Add(this.btn_back);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Estoque:.";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_esto;
        private System.Windows.Forms.Label lbl_que;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label lbl_cadastrar;
        private System.Windows.Forms.Label lbl_produtos;
        private System.Windows.Forms.Button btn_autalizar;
        private System.Windows.Forms.TextBox txt_id_alterar;
        private System.Windows.Forms.TextBox txt_categoria_alterar;
        private System.Windows.Forms.TextBox txt_marca_alterar;
        private System.Windows.Forms.TextBox txt_descricao_alterar;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.TextBox txt_quantidade_alterar;
        private System.Windows.Forms.Label lbl_novos_dados;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_limpar_dados;
        private System.Windows.Forms.Label lbl_alterar;
        private System.Windows.Forms.Label lbl_dados;
        private System.Windows.Forms.Label lbl_att;
        private System.Windows.Forms.Label lbl_dele;
        private System.Windows.Forms.Label lbl_tar;
        private System.Windows.Forms.Label lbl_id_deletar;
        private System.Windows.Forms.TextBox txt_id_delete;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.DataGridView GridEstoque;
    }
}