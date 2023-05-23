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
    public static class Cliente
    {
        const string conn = @"Data Source=LUIZ\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=True;";

        public static DataTable ObterClientes()
        {
            DataTable dt = new DataTable();
            var sql = "Select id, Cpf, Nome, Telefone from Cliente ORDER BY cpf";

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
        public static bool SalvarClientes(DataGridView dgv)
        {
            string sql = "";

            try
            {
                using (SqlConnection cn = new SqlConnection(conn))
                {
                    cn.Open();

                    foreach(DataGridViewRow r in dgv.Rows)
                    {
                        if (Convert.ToInt32("0" + r.Cells["Id"].Value) == 0)
                            sql = "INSERT INTO Cliente (Cpf, Nome, Telefone) VALUES (@Cpf, @Nome, @Telefone)";
                        else
                            sql = "UPDATE Cliente set Cpf=@Cpf, Nome=@Nome, Telefone=@Telefone WHERE Id=@Id";
                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@Cpf", r.Cells["Cpf"].Value);
                            cmd.Parameters.AddWithValue("@Nome", r.Cells["Nome"].Value);
                            cmd.Parameters.AddWithValue("@Telefone", r.Cells["Telefone"].Value);

                            if (Convert.ToInt32("0" + r.Cells["Id"].Value) > 0)
                                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32("0" + r.Cells
                                    ["Id"].Value));
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
