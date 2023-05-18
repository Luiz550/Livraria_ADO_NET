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
            Cadastrar_Usuario Aplicacao = new Cadastrar_Usuario();
            Aplicacao.Show();
            this.Hide();
        }

        private void Cadastrar_Livro_Click(object sender, EventArgs e)
        {
            Cadastrar_Livros Aplicacao = new Cadastrar_Livros();
            Aplicacao.Show();
            this.Hide();
        }
    }
}
