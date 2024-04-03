using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace repair
{
    public partial class Order : Form
    {
        int id_user;
        public Order(int id_u)
        {
            id_u = id_user;
            InitializeComponent();
        }
        static string connString = @" Data Source=MEPHI3-MSSQL;Initial Catalog = ""praktika sentsova""; Integrated Security = True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        string num = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_windows form = new User_windows(id_user);
            form.ShowDialog();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            
            LDate.Text += DateTime.Now.ToLongDateString();
            Random rand = new Random();
            string pool = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            
            int count = 1;
            while(count!=0)
            {
                for (int x = 0; x < 7; x++)
                {
                    num += pool[rand.Next(0, pool.Length)].ToString();
                }
                sqlConnect.Open();
                SqlCommand check = new SqlCommand($"SELECT COUNT(*) as con FROM [dbo].[statement] Where Number ='{num}' ");
                check.Connection = sqlConnect;
                SqlDataReader rd = check.ExecuteReader();
                while (rd.Read())
                {
                    count = Convert.ToInt32(rd["con"]);
                }

                sqlConnect.Close();

            }
            
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            

            SqlCommand logRequst = new SqlCommand();
            logRequst.Connection = sqlConnect;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "AddOrder";


            logRequst.Parameters.AddWithValue("@device", textBox1.Text);
            logRequst.Parameters.AddWithValue("@desctiption", RTBDist.Text);
            logRequst.Parameters.AddWithValue("@id_client", id_user);
            logRequst.Parameters.AddWithValue("@date_start", DateTime.Now);
            logRequst.Parameters.AddWithValue("@id_priority", CBPriority.SelectedIndex); 
            logRequst.Parameters.AddWithValue("@number", num);

            try
            {
                logRequst.ExecuteNonQuery();
                MessageBox.Show("Заявка добавлена");
                this.Hide();
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

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
