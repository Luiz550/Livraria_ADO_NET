using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_Bem
{
    public partial class Cadastrar_Livros : Form
    {
        public Cadastrar_Livros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Strcon = "Data Source=(localdb)\\MSSQLLocalDBf;AttaehDbFilename=C:\\Users\\luizn\\source\\repos\\livro\\livro\\BaseDeDados\\Database1.mdf;Integrated Security=true; Connect timeout=30";
            SqlConnection conexao = new SqlConnection(Strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM tabela", conexao);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ds.Tables[0].TableName;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
                throw;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }
    }
}
