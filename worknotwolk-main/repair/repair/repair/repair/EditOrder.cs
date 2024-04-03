using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repair
{
    public partial class EditOrder : Form
    {
        public int order_id;
        public EditOrder(int or_id)
        {
            order_id = or_id;
            InitializeComponent();
        }
        static string connString = @" Data Source=MEPHI3-MSSQL;Initial Catalog = ""praktika sentsova""; Integrated Security = True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        class status
        {
            public int IDstat { get; set; }
            public string Namestat { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand logRequst = new SqlCommand();
            logRequst.Connection = sqlConnect;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "editOrd";
            logRequst.Parameters.AddWithValue("@id_order", order_id);
            
            logRequst.Parameters.AddWithValue("@desctiption", TbDist.Text);
        
            logRequst.Parameters.AddWithValue("@Dstart", DStart.Value);
            logRequst.Parameters.AddWithValue("@Dend", Dend.Value);
            logRequst.Parameters.AddWithValue("@id_status", CBStatus.SelectedIndex);
            
            logRequst.Parameters.AddWithValue("@priority", CBprior.SelectedIndex);


            try
            {
                logRequst.ExecuteNonQuery();
                MessageBox.Show("Данные  изменены");

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

        private void EditOrder_Load(object sender, EventArgs e)
        {
            
            sqlConnect.Open();
            SqlCommand logRequst = new SqlCommand($"select * from[dbo].[statement] where [id_statement]= {order_id}");
            logRequst.Connection = sqlConnect;
            SqlDataReader rd = logRequst.ExecuteReader();
            while (rd.Read())
            {
                TbDist.Text = rd["desctiption"].ToString();
                label1.Text += rd["equipment"].ToString();
                groupBox1.Text += rd["id_number"].ToString();
                int val = Convert.ToInt32(rd["id_priority"]);
                CBprior.SelectedIndex = val-1;
                DStart.Value = rd.GetDateTime(8);
                Dend.Value = rd.GetDateTime(9);

            }

            sqlConnect.Close();
            sqlConnect.Open();
            List<status> stat = new List<status>();
            SqlCommand logRequstspel = new SqlCommand("Select * from status", sqlConnect);
            logRequstspel.Connection = sqlConnect;
            SqlDataReader rdr = logRequstspel.ExecuteReader();
            while (rdr.Read())
            {
                stat.Add(new status { IDstat = rdr.GetInt32(0), Namestat = rdr.GetString(1) });

            }
            CBStatus.DataSource = stat;
            CBStatus.ValueMember = "IDstat";
            CBStatus.DisplayMember = "Namestat";
            sqlConnect.Close();
        }
    }
}
