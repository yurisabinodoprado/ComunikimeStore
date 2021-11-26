
namespace ComunikimeStore
{
    partial class Cadastrar
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
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.lbl_cadas = new System.Windows.Forms.Label();
            this.lbl_tro = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_categoria.Location = new System.Drawing.Point(357, 100);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(99, 24);
            this.lbl_categoria.TabIndex = 0;
            this.lbl_categoria.Text = "Categoria";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_descricao.Location = new System.Drawing.Point(357, 185);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(103, 24);
            this.lbl_descricao.TabIndex = 1;
            this.lbl_descricao.Text = "Descrição";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_marca.Location = new System.Drawing.Point(357, 271);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(67, 24);
            this.lbl_marca.TabIndex = 2;
            this.lbl_marca.Text = "Marca";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(361, 139);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(391, 20);
            this.txt_categoria.TabIndex = 3;
            this.txt_categoria.TextChanged += new System.EventHandler(this.txt_categoria_TextChanged);
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(361, 311);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(391, 20);
            this.txt_marca.TabIndex = 4;
            this.txt_marca.TextChanged += new System.EventHandler(this.txt_marca_TextChanged);
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(361, 230);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(391, 20);
            this.txt_descricao.TabIndex = 5;
            this.txt_descricao.TextChanged += new System.EventHandler(this.txt_descricao_TextChanged);
            // 
            // lbl_cadas
            // 
            this.lbl_cadas.AutoSize = true;
            this.lbl_cadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadas.ForeColor = System.Drawing.Color.Red;
            this.lbl_cadas.Location = new System.Drawing.Point(467, 27);
            this.lbl_cadas.Name = "lbl_cadas";
            this.lbl_cadas.Size = new System.Drawing.Size(117, 38);
            this.lbl_cadas.TabIndex = 6;
            this.lbl_cadas.Text = "Cadas";
            // 
            // lbl_tro
            // 
            this.lbl_tro.AutoSize = true;
            this.lbl_tro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_tro.Location = new System.Drawing.Point(573, 27);
            this.lbl_tro.Name = "lbl_tro";
            this.lbl_tro.Size = new System.Drawing.Size(69, 38);
            this.lbl_tro.TabIndex = 7;
            this.lbl_tro.Text = "Tro";
            this.lbl_tro.Click += new System.EventHandler(this.lbl_tro_Click);
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_enviar.Location = new System.Drawing.Point(361, 476);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(114, 47);
            this.btn_enviar.TabIndex = 8;
            this.btn_enviar.Text = "Cadastrar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_limpar.Location = new System.Drawing.Point(652, 476);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(91, 47);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
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
            this.btn_back.TabIndex = 10;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(357, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(361, 400);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(391, 20);
            this.txt_quantidade.TabIndex = 12;
            this.txt_quantidade.TextChanged += new System.EventHandler(this.txt_quantidade_TextChanged);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1163, 568);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.lbl_tro);
            this.Controls.Add(this.lbl_cadas);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_categoria);
            this.MaximizeBox = false;
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Cadastrar Produtos:.";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_cadas;
        private System.Windows.Forms.Label lbl_tro;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_categoria;
        public System.Windows.Forms.TextBox txt_marca;
        public System.Windows.Forms.TextBox txt_descricao;
        public System.Windows.Forms.TextBox txt_quantidade;
    }
}