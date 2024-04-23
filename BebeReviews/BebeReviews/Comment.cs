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
    public partial class Comment : Form
    {
        int user_id;
        int title_id;
        public Comment(int us_id, int tit_id)
        {
            title_id = tit_id;
            user_id = us_id;
            InitializeComponent();
        }
        static string connString = @"Data Source=MEPHI3-MSSQL;Initial Catalog=BebeReviews;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private void Comment_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand name = new SqlCommand($"select  ");
            name.Connection = sqlConnect;
            SqlDataReader rd = name.ExecuteReader();
            while (rd.Read())
            {
                
            }
            sqlConnect.Close();
        }
    }
}
