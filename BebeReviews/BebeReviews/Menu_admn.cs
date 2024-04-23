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

namespace BebeReviews
{
    public partial class Menu_admn : Form
    {
        int user_id;
        public Menu_admn(int us_id)
            
        {
            user_id = us_id;
            InitializeComponent();
        }
        static string connString = @"Data Source=MEPHI3-MSSQL;Initial Catalog=BebeReviews;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private void Menu_admn_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand Order = new SqlCommand();
            Order.CommandText = $"SELECT * FROM works";
            Order.Connection = sqlConnect;
            SqlDataAdapter adapter = new SqlDataAdapter(Order);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DGtitle.DataSource = dataSet.Tables[0];
            DGtitle.Columns[0].Visible = false;
            sqlConnect.Close();
        }
    }
}
