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
    public partial class Cadastro_Cliente : Form
    {
        
        public Cadastro_Cliente()
        {
            InitializeComponent();
            dataGridView1.DataSource = Cliente.ObterClientes();
            dataGridView1.Columns["Id"].ReadOnly = true;
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void ButtonClientes_Click(object sender, EventArgs e)
        {
         
        }

        private void ButtonLivros_Click(object sender, EventArgs e)
        { 
        }

        private void Cadastrar_Usuario_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Cliente.SalvarClientes(dataGridView1);
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.DataSource = Cliente.ObterClientes();
        }
    }
}
