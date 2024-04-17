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

namespace WindowsFormsApp1
{
    public partial class menu_user : Form
    {
        public menu_user()
        {
            InitializeComponent();
        }
        static string ConnString = @"Data Source=MEPHI3-MSSQL;Initial Catalog=BebeReviews;Integrated Security=True";
       
        SqlConnection sqlConnect = new SqlConnection(ConnString);

        private void menu_user_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand Title = new SqlCommand();
            Title.CommandText = $"SELECT * from works ";
            Title.Connection = sqlConnect;
            SqlDataAdapter adapter = new SqlDataAdapter(Title);
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
            sqlConnect.Close();
        }

        private void HelloUser_Click(object sender, EventArgs e)
        {

        }
    }
}
