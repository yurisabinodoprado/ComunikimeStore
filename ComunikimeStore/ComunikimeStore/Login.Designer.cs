
namespace ComunikimeStore
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_comuniki = new System.Windows.Forms.Label();
            this.lbl_me = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_store = new System.Windows.Forms.Label();
            this.btn_logar = new System.Windows.Forms.Button();
            this.lbl_slogan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_comuniki
            // 
            this.lbl_comuniki.AutoSize = true;
            this.lbl_comuniki.BackColor = System.Drawing.Color.Black;
            this.lbl_comuniki.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comuniki.ForeColor = System.Drawing.Color.Red;
            this.lbl_comuniki.Location = new System.Drawing.Point(166, 68);
            this.lbl_comuniki.Name = "lbl_comuniki";
            this.lbl_comuniki.Size = new System.Drawing.Size(161, 38);
            this.lbl_comuniki.TabIndex = 0;
            this.lbl_comuniki.Text = "Comuniki";
            this.lbl_comuniki.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_me
            // 
            this.lbl_me.AutoSize = true;
            this.lbl_me.BackColor = System.Drawing.Color.Black;
            this.lbl_me.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_me.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_me.Location = new System.Drawing.Point(320, 68);
            this.lbl_me.Name = "lbl_me";
            this.lbl_me.Size = new System.Drawing.Size(64, 38);
            this.lbl_me.TabIndex = 1;
            this.lbl_me.Text = "Me";
            this.lbl_me.Click += new System.EventHandler(this.lb_me_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(173, 179);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(66, 16);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Usuário:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.Black;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.Color.White;
            this.lbl_senha.Location = new System.Drawing.Point(173, 261);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(56, 16);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(173, 212);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(211, 20);
            this.txt_usuario.TabIndex = 5;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(176, 287);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(211, 20);
            this.txt_senha.TabIndex = 6;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // lbl_store
            // 
            this.lbl_store.AutoSize = true;
            this.lbl_store.BackColor = System.Drawing.Color.Black;
            this.lbl_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_store.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_store.Location = new System.Drawing.Point(245, 106);
            this.lbl_store.Name = "lbl_store";
            this.lbl_store.Size = new System.Drawing.Size(59, 25);
            this.lbl_store.TabIndex = 7;
            this.lbl_store.Text = "Store";
            // 
            // btn_logar
            // 
            this.btn_logar.BackColor = System.Drawing.Color.White;
            this.btn_logar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_logar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logar.Location = new System.Drawing.Point(229, 350);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_logar.Size = new System.Drawing.Size(98, 39);
            this.btn_logar.TabIndex = 8;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = false;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // lbl_slogan
            // 
            this.lbl_slogan.AutoSize = true;
            this.lbl_slogan.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slogan.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_slogan.Location = new System.Drawing.Point(187, 131);
            this.lbl_slogan.Name = "lbl_slogan";
            this.lbl_slogan.Size = new System.Drawing.Size(187, 23);
            this.lbl_slogan.TabIndex = 9;
            this.lbl_slogan.Text = "Performance de alto nível!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.lbl_slogan);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.lbl_store);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_me);
            this.Controls.Add(this.lbl_comuniki);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Comunikime Store:.";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_comuniki;
        private System.Windows.Forms.Label lbl_me;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_store;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Label lbl_slogan;
    }
}

