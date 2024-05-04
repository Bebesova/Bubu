using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference
{
    public partial class Auth : Form
    {
        static string connString = @"Data Source=DESKTOP-MPV0NJU;Initial Catalog=BesRep;Integrated Security=True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private string text = string.Empty;
        int count = 0;
        int counter = 0;
        int s = 10;
        string productPhoto = "cap";
        List<string> capch = new List<string>() { "smwm", "w68hp", "76447" };
        string trueCap;
        public Auth()
        {
            InitializeComponent();
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
                    int role = sqlReader.GetInt32(8);
                    int id_user = sqlReader.GetInt32(0);
                    switch (role)
                    {
                        case 1:
                            MessageBox.Show("Вы вошли как участник");
                            Menu_User fоrm = new Menu_User();
                            this.Hide();
                            fоrm.ShowDialog();


                            break;
                        case 2:
                            MessageBox.Show("Вы вошли как модератор");
                            Executor_menu Efrm = new Executor_menu(id_user);
                            this.Hide();
                            Efrm.ShowDialog();
                            break;
                        case 3:
                            MessageBox.Show("вы вошли как  жюри");
                            User_windows frm = new User_windows(id_user);
                            this.Hide();
                            frm.ShowDialog();
                            break;
                         case 4:
                            MessageBox.Show("вы вошли как организатор");
                            Profile frm = new Profile(id_user);
                            this.Hide();
                            frm.ShowDialog();
                            break;


                    }

                }
                else
                {
                    MessageBox.Show("Пароль или логин не верный");
                    count++;


                }
            }
            else
            {
                MessageBox.Show("Капча введена неверна");
                count++;

            }
            sqlConnect.Close();
        
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            // загрузка капчи
            Random rnd = new Random();
            int value = rnd.Next(1, 3);

            trueCap = capch[value - 1];
            
            RTBcaptcha.Text = trueCap;
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            productPhoto += $"{value}";
            string photoPath = Path.Combine(projectDirectory, $"images\\{productPhoto}.jpg");

            PBcaptcha.Image = Image.FromFile(photoPath);
        }
    }
}
