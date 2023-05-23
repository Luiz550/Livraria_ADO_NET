using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_Bem
{
    public partial class Cadastro_Livros : Form
    {
        public Cadastro_Livros()
        {
            InitializeComponent();
            dataGridView1.DataSource = Livros.ObterLivro();
            dataGridView1.Columns["IdLivro"].ReadOnly = true;
        }

        private void Cadastrar_Livro_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Livros.SalvarLivro(dataGridView1);
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.DataSource = Livros.ObterLivro();
        }
    }
}
