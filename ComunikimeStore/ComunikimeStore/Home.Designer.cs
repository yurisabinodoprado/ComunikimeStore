
namespace ComunikimeStore
{
    partial class Menu
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
            this.btn_estoque = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.lbl_cominiki = new System.Windows.Forms.Label();
            this.lbl_me = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_slogan = new System.Windows.Forms.Label();
            this.lbl_estoque = new System.Windows.Forms.Label();
            this.lbl_vendas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_estoque
            // 
            this.btn_estoque.BackColor = System.Drawing.Color.Black;
            this.btn_estoque.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_estoque.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_estoque.Image = global::ComunikimeStore.Properties.Resources.icon_estoque;
            this.btn_estoque.Location = new System.Drawing.Point(280, 266);
            this.btn_estoque.Name = "btn_estoque";
            this.btn_estoque.Size = new System.Drawing.Size(109, 83);
            this.btn_estoque.TabIndex = 0;
            this.btn_estoque.UseVisualStyleBackColor = false;
            this.btn_estoque.Click += new System.EventHandler(this.btn_estoque_Click);
            // 
            // btn_vendas
            // 
            this.btn_vendas.BackColor = System.Drawing.Color.Black;
            this.btn_vendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vendas.Image = global::ComunikimeStore.Properties.Resources.icon_vendas;
            this.btn_vendas.Location = new System.Drawing.Point(628, 256);
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.Size = new System.Drawing.Size(109, 93);
            this.btn_vendas.TabIndex = 1;
            this.btn_vendas.UseVisualStyleBackColor = false;
            this.btn_vendas.Click += new System.EventHandler(this.btn_vendas_Click);
            // 
            // lbl_cominiki
            // 
            this.lbl_cominiki.AutoSize = true;
            this.lbl_cominiki.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cominiki.ForeColor = System.Drawing.Color.Red;
            this.lbl_cominiki.Location = new System.Drawing.Point(410, 28);
            this.lbl_cominiki.Name = "lbl_cominiki";
            this.lbl_cominiki.Size = new System.Drawing.Size(161, 38);
            this.lbl_cominiki.TabIndex = 2;
            this.lbl_cominiki.Text = "Comuniki";
            this.lbl_cominiki.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_me
            // 
            this.lbl_me.AutoSize = true;
            this.lbl_me.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_me.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_me.Location = new System.Drawing.Point(563, 28);
            this.lbl_me.Name = "lbl_me";
            this.lbl_me.Size = new System.Drawing.Size(64, 38);
            this.lbl_me.TabIndex = 3;
            this.lbl_me.Text = "Me";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(498, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Store";
            // 
            // lbl_slogan
            // 
            this.lbl_slogan.AutoSize = true;
            this.lbl_slogan.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slogan.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_slogan.Location = new System.Drawing.Point(428, 91);
            this.lbl_slogan.Name = "lbl_slogan";
            this.lbl_slogan.Size = new System.Drawing.Size(187, 23);
            this.lbl_slogan.TabIndex = 5;
            this.lbl_slogan.Text = "Performance de alto nível!";
            this.lbl_slogan.Click += new System.EventHandler(this.lbl_slogan_Click);
            // 
            // lbl_estoque
            // 
            this.lbl_estoque.AutoSize = true;
            this.lbl_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estoque.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_estoque.Location = new System.Drawing.Point(288, 371);
            this.lbl_estoque.Name = "lbl_estoque";
            this.lbl_estoque.Size = new System.Drawing.Size(91, 25);
            this.lbl_estoque.TabIndex = 6;
            this.lbl_estoque.Text = "Estoque";
            // 
            // lbl_vendas
            // 
            this.lbl_vendas.AutoSize = true;
            this.lbl_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendas.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_vendas.Location = new System.Drawing.Point(642, 371);
            this.lbl_vendas.Name = "lbl_vendas";
            this.lbl_vendas.Size = new System.Drawing.Size(86, 25);
            this.lbl_vendas.TabIndex = 7;
            this.lbl_vendas.Text = "Vendas";
            this.lbl_vendas.Click += new System.EventHandler(this.lbl_vendas_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1063, 568);
            this.Controls.Add(this.lbl_vendas);
            this.Controls.Add(this.lbl_estoque);
            this.Controls.Add(this.lbl_slogan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_me);
            this.Controls.Add(this.lbl_cominiki);
            this.Controls.Add(this.btn_vendas);
            this.Controls.Add(this.btn_estoque);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Home:.";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_estoque;
        private System.Windows.Forms.Button btn_vendas;
        private System.Windows.Forms.Label lbl_cominiki;
        private System.Windows.Forms.Label lbl_me;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_slogan;
        private System.Windows.Forms.Label lbl_estoque;
        private System.Windows.Forms.Label lbl_vendas;
    }
}