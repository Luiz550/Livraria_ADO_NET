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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnAcesso_Click(object sender, EventArgs e)
        {
            String User = "admin";
            String Password = "admin";



            if (TxtUsuario.Text == User & TxtSenha.Text == Password)
            {
                MessageBox.Show("Acesso Liberado");
                Aplicacao Form1 = new Aplicacao();
                Form1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("senha incorreta");
            }
        }
    }
}
