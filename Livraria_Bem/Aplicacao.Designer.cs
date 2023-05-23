namespace Livraria_Bem
{
    partial class Aplicacao
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
            this.ButtonConEnprest = new System.Windows.Forms.Button();
            this.ButtonConUsuario = new System.Windows.Forms.Button();
            this.ButtonEfetuarFiltro = new System.Windows.Forms.Button();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cadastrar_Livro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonEsmprestim = new System.Windows.Forms.Button();
            this.ButtonLivros = new System.Windows.Forms.Button();
            this.ButtonVenda = new System.Windows.Forms.Button();
            this.Cadastrar_Usuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonConEnprest
            // 
            this.ButtonConEnprest.Location = new System.Drawing.Point(22, 355);
            this.ButtonConEnprest.Name = "ButtonConEnprest";
            this.ButtonConEnprest.Size = new System.Drawing.Size(117, 42);
            this.ButtonConEnprest.TabIndex = 21;
            this.ButtonConEnprest.Text = "Consultar emprestimos";
            this.ButtonConEnprest.UseVisualStyleBackColor = true;
            // 
            // ButtonConUsuario
            // 
            this.ButtonConUsuario.Location = new System.Drawing.Point(22, 298);
            this.ButtonConUsuario.Name = "ButtonConUsuario";
            this.ButtonConUsuario.Size = new System.Drawing.Size(117, 42);
            this.ButtonConUsuario.TabIndex = 20;
            this.ButtonConUsuario.Text = "Consultar Usuarios";
            this.ButtonConUsuario.UseVisualStyleBackColor = true;
            this.ButtonConUsuario.Click += new System.EventHandler(this.ButtonConUsuario_Click);
            // 
            // ButtonEfetuarFiltro
            // 
            this.ButtonEfetuarFiltro.Location = new System.Drawing.Point(508, 75);
            this.ButtonEfetuarFiltro.Name = "ButtonEfetuarFiltro";
            this.ButtonEfetuarFiltro.Size = new System.Drawing.Size(40, 23);
            this.ButtonEfetuarFiltro.TabIndex = 19;
            this.ButtonEfetuarFiltro.Text = "button6";
            this.ButtonEfetuarFiltro.UseVisualStyleBackColor = true;
            this.ButtonEfetuarFiltro.Click += new System.EventHandler(this.ButtonEfetuarFiltro_Click);
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(285, 75);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(217, 22);
            this.TxtFiltro.TabIndex = 18;
            this.TxtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(230, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar";
            // 
            // Cadastrar_Livro
            // 
            this.Cadastrar_Livro.Location = new System.Drawing.Point(662, 53);
            this.Cadastrar_Livro.Name = "Cadastrar_Livro";
            this.Cadastrar_Livro.Size = new System.Drawing.Size(131, 38);
            this.Cadastrar_Livro.TabIndex = 16;
            this.Cadastrar_Livro.Text = "Cadastrar livro";
            this.Cadastrar_Livro.UseVisualStyleBackColor = true;
            this.Cadastrar_Livro.Click += new System.EventHandler(this.Cadastrar_Livro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(156, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(473, 282);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ButtonEsmprestim
            // 
            this.ButtonEsmprestim.Location = new System.Drawing.Point(22, 233);
            this.ButtonEsmprestim.Name = "ButtonEsmprestim";
            this.ButtonEsmprestim.Size = new System.Drawing.Size(117, 42);
            this.ButtonEsmprestim.TabIndex = 14;
            this.ButtonEsmprestim.Text = "Efetuar emprestimo";
            this.ButtonEsmprestim.UseVisualStyleBackColor = true;
            // 
            // ButtonLivros
            // 
            this.ButtonLivros.Location = new System.Drawing.Point(22, 115);
            this.ButtonLivros.Name = "ButtonLivros";
            this.ButtonLivros.Size = new System.Drawing.Size(117, 41);
            this.ButtonLivros.TabIndex = 13;
            this.ButtonLivros.Text = "Livros";
            this.ButtonLivros.UseVisualStyleBackColor = true;
            this.ButtonLivros.Click += new System.EventHandler(this.ButtonLivros_Click);
            // 
            // ButtonVenda
            // 
            this.ButtonVenda.Location = new System.Drawing.Point(22, 179);
            this.ButtonVenda.Name = "ButtonVenda";
            this.ButtonVenda.Size = new System.Drawing.Size(117, 32);
            this.ButtonVenda.TabIndex = 12;
            this.ButtonVenda.Text = "Efetuar venda";
            this.ButtonVenda.UseVisualStyleBackColor = true;
            // 
            // Cadastrar_Usuario
            // 
            this.Cadastrar_Usuario.Location = new System.Drawing.Point(8, 53);
            this.Cadastrar_Usuario.Name = "Cadastrar_Usuario";
            this.Cadastrar_Usuario.Size = new System.Drawing.Size(131, 38);
            this.Cadastrar_Usuario.TabIndex = 11;
            this.Cadastrar_Usuario.Text = "Cadastrar usuário";
            this.Cadastrar_Usuario.UseVisualStyleBackColor = true;
            this.Cadastrar_Usuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // Aplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonConEnprest);
            this.Controls.Add(this.ButtonConUsuario);
            this.Controls.Add(this.ButtonEfetuarFiltro);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cadastrar_Livro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonEsmprestim);
            this.Controls.Add(this.ButtonLivros);
            this.Controls.Add(this.ButtonVenda);
            this.Controls.Add(this.Cadastrar_Usuario);
            this.Name = "Aplicacao";
            this.Text = "Aplicacao";
            this.Load += new System.EventHandler(this.Aplicacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonConEnprest;
        private System.Windows.Forms.Button ButtonConUsuario;
        private System.Windows.Forms.Button ButtonEfetuarFiltro;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cadastrar_Livro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonEsmprestim;
        private System.Windows.Forms.Button ButtonLivros;
        private System.Windows.Forms.Button ButtonVenda;
        private System.Windows.Forms.Button Cadastrar_Usuario;
    }
}