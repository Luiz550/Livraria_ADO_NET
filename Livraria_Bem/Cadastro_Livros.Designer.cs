namespace Livraria_Bem
{
    partial class Cadastro_Livros
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
            this.Cadastrar_Livro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(571, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // Cadastrar_Livro
            // 
            this.Cadastrar_Livro.Location = new System.Drawing.Point(342, 355);
            this.Cadastrar_Livro.Name = "Cadastrar_Livro";
            this.Cadastrar_Livro.Size = new System.Drawing.Size(75, 23);
            this.Cadastrar_Livro.TabIndex = 1;
            this.Cadastrar_Livro.Text = "Salvar";
            this.Cadastrar_Livro.UseVisualStyleBackColor = true;
            this.Cadastrar_Livro.Click += new System.EventHandler(this.Cadastrar_Livro_Click);
            // 
            // Cadastro_Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cadastrar_Livro);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cadastro_Livros";
            this.Text = "Cadastro_Livros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Cadastrar_Livro;
    }
}