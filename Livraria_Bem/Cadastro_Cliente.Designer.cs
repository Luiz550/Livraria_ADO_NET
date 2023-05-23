namespace Livraria_Bem
{
    partial class Cadastro_Cliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonClientes = new System.Windows.Forms.Button();
            this.ButtonLivros = new System.Windows.Forms.Button();
            this.ButtonJuncao = new System.Windows.Forms.Button();
            this.Cadastrar_Usuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // ButtonClientes
            // 
            this.ButtonClientes.Location = new System.Drawing.Point(139, 409);
            this.ButtonClientes.Name = "ButtonClientes";
            this.ButtonClientes.Size = new System.Drawing.Size(75, 23);
            this.ButtonClientes.TabIndex = 1;
            this.ButtonClientes.Text = "cliente";
            this.ButtonClientes.UseVisualStyleBackColor = true;
            this.ButtonClientes.Click += new System.EventHandler(this.ButtonClientes_Click);
            // 
            // ButtonLivros
            // 
            this.ButtonLivros.Location = new System.Drawing.Point(301, 409);
            this.ButtonLivros.Name = "ButtonLivros";
            this.ButtonLivros.Size = new System.Drawing.Size(75, 23);
            this.ButtonLivros.TabIndex = 2;
            this.ButtonLivros.Text = "livros";
            this.ButtonLivros.UseVisualStyleBackColor = true;
            this.ButtonLivros.Click += new System.EventHandler(this.ButtonLivros_Click);
            // 
            // ButtonJuncao
            // 
            this.ButtonJuncao.Location = new System.Drawing.Point(446, 409);
            this.ButtonJuncao.Name = "ButtonJuncao";
            this.ButtonJuncao.Size = new System.Drawing.Size(75, 23);
            this.ButtonJuncao.TabIndex = 3;
            this.ButtonJuncao.Text = "junçao";
            this.ButtonJuncao.UseVisualStyleBackColor = true;
            // 
            // Cadastrar_Usuario
            // 
            this.Cadastrar_Usuario.Location = new System.Drawing.Point(328, 310);
            this.Cadastrar_Usuario.Name = "Cadastrar_Usuario";
            this.Cadastrar_Usuario.Size = new System.Drawing.Size(75, 23);
            this.Cadastrar_Usuario.TabIndex = 4;
            this.Cadastrar_Usuario.Text = "Cadastrar Usuario";
            this.Cadastrar_Usuario.UseVisualStyleBackColor = true;
            this.Cadastrar_Usuario.Click += new System.EventHandler(this.Cadastrar_Usuario_Click);
            // 
            // Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cadastrar_Usuario);
            this.Controls.Add(this.ButtonJuncao);
            this.Controls.Add(this.ButtonLivros);
            this.Controls.Add(this.ButtonClientes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cadastro_Cliente";
            this.Text = "Cadastro_Cliente";
            this.Load += new System.EventHandler(this.Cadastro_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonClientes;
        private System.Windows.Forms.Button ButtonLivros;
        private System.Windows.Forms.Button ButtonJuncao;
        private System.Windows.Forms.Button Cadastrar_Usuario;
    }
}