using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BebeReviews
{
    public partial class Menu_user : Form
    {
        int user_id;
        public Menu_user(int us_id)
        {
            user_id = us_id;
            InitializeComponent();
        }
        int title_id;
        int rewiew_id;
        int count = 0;
        int val;
        int s = 10;
        string textrew;
        string textick;
        static string connString = @"Data Source=MEPHI3-MSSQL;Initial Catalog=BebeReviews;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private void Form2_Load(object sender, EventArgs e)
        {
            
            sqlConnect.Open();
            SqlCommand name = new SqlCommand($"Select NickName from Users where id_user = {user_id} ");
            name.Connection = sqlConnect;
            SqlDataReader rd = name.ExecuteReader();
            while (rd.Read())
            {
                HelloUser.Text = " Приветик, ";
                HelloUser.Text += rd["NickName"].ToString();
            }
            sqlConnect.Close();

            sqlConnect.Open();
            SqlCommand Order = new SqlCommand();
            Order.CommandText = $"SELECT * FROM works";
            Order.Connection = sqlConnect;
            SqlDataAdapter adapter = new SqlDataAdapter(Order);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DGTitle.DataSource = dataSet.Tables[0];
            DGTitle.Columns[0].Visible = false;
            sqlConnect.Close();

            sqlConnect.Open();
            SqlCommand Rating = new SqlCommand();
            Rating.CommandText = $"SELECT * from ViewReview ";
            Rating.Connection = sqlConnect;
            SqlDataAdapter vwv = new SqlDataAdapter(Rating);
            DataSet dvwv = new DataSet();
            vwv.Fill(dvwv);
            DGRev.DataSource = dvwv.Tables[0];
            DGRev.Columns[0].Visible = false;
            DGRev.Columns[6].Visible = false;
            DGRev.Columns[7].Visible = false;
            sqlConnect.Close();

          

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




            
        }

        private void DGTitle_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            title_id = Convert.ToInt32(DGTitle.Rows[e.RowIndex].Cells[0].Value);
            sqlConnect.Close();
            sqlConnect.Open();
            SqlCommand check = new SqlCommand($"SELECT Отзыв, Оценка,COUNT(Отзыв) as con FROM ViewReview  Where [id_title]= {title_id} and id_user = {user_id} group by Отзыв,Оценка");
            check.Connection = sqlConnect;
            SqlDataReader rdr = check.ExecuteReader();
            while (rdr.Read())
            {
                count = Convert.ToInt32(rdr["con"]);
                textrew = (rdr["Отзыв"]).ToString();
                val = Convert.ToInt32(rdr["Оценка"]);
            }
            sqlConnect.Close();
        }

        private void DGRev_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rewiew_id = Convert.ToInt32(DGRev.Rows[e.RowIndex].Cells[0].Value);
            sqlConnect.Close();
            sqlConnect.Open();
            SqlCommand check = new SqlCommand($"SELECT Отзыв, Оценка FROM ViewReview  Where [id_review]= {rewiew_id} ");
            check.Connection = sqlConnect;
            SqlDataReader rdr = check.ExecuteReader();
            while (rdr.Read())
            {

                textick = (rdr["Отзыв"]).ToString();
                RtbRew.Text = textick;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (DGTitle.DataSource as DataTable).DefaultView.RowFilter = $"[Произведение] LIKE '%{filtername.Text}%'";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (DGTitle.DataSource as DataTable).DefaultView.RowFilter = $"[Автор] LIKE '%{filterAuther.Text}%'";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(s > 0)
            {
                s -= 1;
                

            }
            else
            {
                s = 10;
                Form2_Load(sender,e);
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand logRequst = new SqlCommand();
            logRequst.Connection = sqlConnect;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "Savereview";
            logRequst.Parameters.AddWithValue("@id_title", title_id);
            logRequst.Parameters.AddWithValue("@rating", numrat.Value);
            logRequst.Parameters.AddWithValue("@text", Review.Text);
            logRequst.Parameters.AddWithValue("@id_user", user_id);
            logRequst.Parameters.AddWithValue("@Date", DateTime.Now);

            try
            {
                logRequst.ExecuteNonQuery();
                MessageBox.Show("Отзыв добавлен");
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
