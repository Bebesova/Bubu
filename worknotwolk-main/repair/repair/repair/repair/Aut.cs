using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace repair
{
    public partial class Аuth : Form
    {
        public Аuth()
        {
            InitializeComponent();
        }
        static string connString = @" Data Source=MEPHI3-MSSQL;Initial Catalog = ""praktika sentsova""; Integrated Security = True";

        SqlConnection sqlConnect = new SqlConnection(connString);
        private string text = string.Empty;
        int count = 0;
        int counter = 0;
        int s = 10;
        string productPhoto = "cap";
        List<string> capch = new List<string>() { "smwm", "w68hp", "76447" };
        string trueCap;
        private void Аuth_Load(object sender, EventArgs e)
        {
            // загрузка капчи
            Random rnd = new Random();
            int value = rnd.Next(1,3);
            
            trueCap = capch[value -1];
            label6.Text = trueCap;
            RTBcaptcha.Text = trueCap;
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            productPhoto+= $"{value}";
            string photoPath = Path.Combine(projectDirectory, $"images\\{productPhoto}.jpg");

            PBcaptcha.Image = Image.FromFile(photoPath);
        }

  
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BAut_Click(object sender, EventArgs e)
        {

            sqlConnect.Open();
            SqlCommand logRequst = new SqlCommand();
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "Aut";
            logRequst.Parameters.AddWithValue("@Login", Login.Text);
            logRequst.Parameters.AddWithValue("@Password", Password.Text);
            logRequst.Connection = sqlConnect;
            SqlDataReader sqlReader = logRequst.ExecuteReader();
            sqlReader.Read();
            string cp = Convert.ToString(RTBcaptcha.Text);
            if (cp == trueCap)
            {
                if (sqlReader.HasRows)
                {
                    MessageBox.Show("Успешно");
                    int role = sqlReader.GetInt32(4);
                    int id_user = sqlReader.GetInt32(0);
                    switch (role)
                    {
                        case 1:
                            MessageBox.Show("вы вошли как заказчик");
                            User_windows frm = new User_windows(id_user);
                            this.Hide();
                            frm.ShowDialog();
                            break;


                            break;
                        case 2:
                            
                            MessageBox.Show("Вы вошли как менеджер");
                            Manager_menu fоrm = new Manager_menu(id_user);
                            this.Hide();
                            fоrm.ShowDialog();
                            break;

                        case 3:
                            MessageBox.Show("Вы вошли как исполнитель");
                            break;

                    }

                }
                else
                {
                    MessageBox.Show("Пароль или логин не верный");
                    count++;
                    timerbl.Enabled = true;
                    label4.Visible = true;
                    label1.Visible = true;
                    label1.Text = s.ToString();
                    BAut.Enabled = false;

                }
            }
            else 
            {
                MessageBox.Show("Капча введена неверна");
                count++;
                timerbl.Enabled = true;
                label4.Visible = true;
                label1.Visible = true;
                label1.Text = s.ToString();
                BAut.Enabled = false;
            }
            sqlConnect.Close();
        }
    }
}
