using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_Bem
{
    public static class Livros
    {
        const string conn = @"Data Source=LUIZ\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=True;";


        public static DataTable ObterLivro()
        {
            DataTable dt = new DataTable();
            var sql = "Select IdLivro, Titulo, Editora, Autor, Genero,Ano, Isbn from Livro ORDER BY Titulo";

            try
            {
                using (SqlConnection cn = new SqlConnection(conn))
                {
                    cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            return dt;
        }

        public static bool SalvarLivro(DataGridView dgv)
        {
            string sql = "";

            try
            {
                using (SqlConnection cn = new SqlConnection(conn))
                {
                    cn.Open();

                    foreach (DataGridViewRow r in dgv.Rows)
                    {
                        if (Convert.ToInt32("0" + r.Cells["IdLivro"].Value) == 0)
                            sql = "INSERT INTO Livro (Titulo,Editora, Autor, Genero,Ano,Isbn) VALUES (@Titulo, @Editora ,@Autor ,@Genero ,@Ano ,@Isbn)";
                        else
                            sql = "UPDATE Livro set Titulo=@Titulo, Editora=@Editora, Autor=@Autor, Genero=@Genero, Ano=@Ano, Isbn=@Isbn WHERE IdLivro=@IdLivro";
                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@Titulo", r.Cells["Titulo"].Value);
                            cmd.Parameters.AddWithValue("@Editora", r.Cells["Editora"].Value);
                            cmd.Parameters.AddWithValue("@Autor", r.Cells["Autor"].Value);
                            cmd.Parameters.AddWithValue("@Genero", r.Cells["Genero"].Value);
                            cmd.Parameters.AddWithValue("@Ano", r.Cells["Ano"].Value);
                            cmd.Parameters.AddWithValue("@Isbn", r.Cells["Isbn"].Value);

                            if (Convert.ToInt32("0" + r.Cells["IdLivro"].Value) > 0)
                                cmd.Parameters.AddWithValue("@IdLivro", Convert.ToInt32("0" + r.Cells
                                    ["IdLivro"].Value));
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return false;
            }
        }

      
    }
}
