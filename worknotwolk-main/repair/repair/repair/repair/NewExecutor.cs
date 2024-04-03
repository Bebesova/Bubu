using Microsoft.SqlServer.Server;
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

namespace repair
{
    public partial class NewExecutor : Form
    {
        int Problem_id;
        public NewExecutor(int pr_id)
        {
            InitializeComponent();
            Problem_id = pr_id;
        }
        int User_id =1;
        static string connString = @" Data Source=MEPHI3-MSSQL;Initial Catalog = ""praktika sentsova""; Integrated Security = True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NewExecutor_Load(object sender, EventArgs e)
        {
            SqlCommand logRequst = new SqlCommand();



            logRequst.CommandText = $"SELECT * FROM [dbo].[users] where role =3 ";
            logRequst.Connection = sqlConnect;
            SqlDataAdapter adapter = new SqlDataAdapter(logRequst);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DGExecutor.DataSource = dataSet.Tables[0];
            DGExecutor.Columns[0].Visible = false;
        }

        private void DGExecutor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            User_id = Convert.ToInt32(DGExecutor.Rows[e.RowIndex].Cells[0].Value);
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void BAddEx_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand logRequst = new SqlCommand();
            logRequst.Connection = sqlConnect;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "Addex";

            logRequst.Parameters.AddWithValue("@id_user", User_id);
            logRequst.Parameters.AddWithValue("@id_problem", Problem_id);



            try
            {
                logRequst.ExecuteNonQuery();
                MessageBox.Show("Успешно");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! : " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();

            }
        }
    }
}
