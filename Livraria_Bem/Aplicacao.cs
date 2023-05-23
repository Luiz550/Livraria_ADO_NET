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
    public partial class Aplicacao : Form
    {
        public Aplicacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente Aplicacao = new Cadastro_Cliente();
            Aplicacao.Show();
            this.Hide();
        }

        private void Cadastrar_Livro_Click(object sender, EventArgs e)
        {
            Cadastro_Livros Aplicacao = new Cadastro_Livros();
            Aplicacao.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonLivros_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Livros.ObterLivro();
        }

        private void ButtonConUsuario_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Cliente.ObterClientes();
        }

        private void ButtonEfetuarFiltro_Click(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = Livros.ObterLivro();
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        { /*
            if (TxtFiltro.Text!="")
            {
                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                { 
                    r.Visible = false; 
                }
                foreach(DataGridViewRow r in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(TxtFiltro.Text.ToUpper())==0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
               dataGridView1.DataSource = Livros.ObterLivro();
            } */
        }

        private void Aplicacao_Load(object sender, EventArgs e)
        {
            
        }
    }
}
