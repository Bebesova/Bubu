using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BebeReviews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string connString = @"Data Source=MEPHI3-MSSQL;Initial Catalog=BebeReviews;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand logRequst = new SqlCommand();
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "Auth";
            logRequst.Parameters.AddWithValue("@Login", Login.Text);
            logRequst.Parameters.AddWithValue("@Password", Password.Text);
            logRequst.Connection = sqlConnect;
            SqlDataReader sqlReader = logRequst.ExecuteReader();
            sqlReader.Read();
            

            if (sqlReader.HasRows)
            {
                MessageBox.Show("Успешно");
                int role = sqlReader.GetInt32(5);
                int user_id = sqlReader.GetInt32(0);
                switch (role)
                {
                    case 1:
                        MessageBox.Show("вы вошли как администратор");
                        Menu_admn frm = new Menu_admn(user_id);
                        this.Hide();
                        frm.ShowDialog();
                        break;



                    case 2:

                        MessageBox.Show("Вы вошли как модератор");
                       
                        break;

                    case 3:
                        MessageBox.Show("Вы вошли как пользователь");
                        Menu_user fоrm = new Menu_user(user_id);
                        this.Hide();
                        fоrm.ShowDialog();
                        break;

                }

            }
            else
            {
                MessageBox.Show("Пароль или логин не верный");


            }
            sqlConnect.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
