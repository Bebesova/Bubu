using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace repair
{
    public partial class NewProblem : Form
    {
        int Order_id;
        public NewProblem(int ord_id)
        {
            Order_id = ord_id;
            InitializeComponent();
        }
        static string connString = @" Data Source=MEPHI3-MSSQL;Initial Catalog = ""praktika sentsova""; Integrated Security = True";
        SqlConnection sqlConnect = new SqlConnection(connString);

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
      
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();

            SqlCommand logRequst = new SqlCommand();
            logRequst.Connection = sqlConnect;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "NewProblem";
            logRequst.Parameters.AddWithValue("@id_order ", Order_id);
            logRequst.Parameters.AddWithValue("@desctiption", RTProblem.Text);
            logRequst.Parameters.AddWithValue("@start_date", DateTime.Now);
            logRequst.Parameters.AddWithValue("@end_date", DateTime.Now);
            logRequst.Parameters.AddWithValue("@id_priority", CBprior.SelectedIndex);
            logRequst.Parameters.AddWithValue("@id_priority", 1);
            try
            {
                logRequst.ExecuteNonQuery();
                MessageBox.Show("Заявка добавлена");

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

        private void NewProblem_Load(object sender, EventArgs e)
        {
            
            sqlConnect.Open();
            SqlCommand logRequst = new SqlCommand($"select * from [dbo].[statement] where [id_statement]= {Order_id}");
            logRequst.Connection = sqlConnect;
            SqlDataReader rd = logRequst.ExecuteReader();
            while (rd.Read())
            {

                groupBox1.Text += ' ' + rd["Номер заказа"].ToString();
                Ldevice.Text += ' ' + rd["Устройство"].ToString();
                int val = Convert.ToInt32(rd["Приоритет"]);
                CBprior.SelectedIndex = val - 1;


            }
            sqlConnect.Close();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
