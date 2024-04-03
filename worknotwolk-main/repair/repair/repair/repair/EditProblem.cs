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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace repair
{
    public partial class EditProblem : Form
    {
        public int problem_id;
        public EditProblem(int id_prob)
        {
            problem_id = id_prob;
            InitializeComponent();
        }
        
        static string connString = @" Data Source=MEPHI3-MSSQL;Initial Catalog = ""praktika sentsova""; Integrated Security = True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand logRequst = new SqlCommand();
            logRequst.Connection = sqlConnect;
            logRequst.CommandType = CommandType.StoredProcedure;
            logRequst.CommandText = "editOrd";
            logRequst.Parameters.AddWithValue("@problem_id", problem_id);

            logRequst.Parameters.AddWithValue("@desctiption", RTBDist.Text);

            logRequst.Parameters.AddWithValue("@Dstart", Dstart.Value);
            logRequst.Parameters.AddWithValue("@Dend", Dend.Value);
            logRequst.Parameters.AddWithValue("@id_status", CBStatus.SelectedIndex);

            logRequst.Parameters.AddWithValue("@priority", CBPriority.SelectedIndex);


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
        class status
        {
            public int IDstat { get; set; }
            public string Namestat { get; set; }
        }
        private void EditProblem_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            
            SqlCommand prob = new SqlCommand($"select * from ViewProblem where [id_statement] = {problem_id}");
            prob.Connection = sqlConnect;
            SqlDataReader rd = prob.ExecuteReader();
            while (rd.Read())
            {
                RTBDist.Text = rd["desctiption"].ToString();
                LDivace.Text += rd["equipment"].ToString();     
                int val = Convert.ToInt32(rd["id_priority"]);
                CBPriority.SelectedIndex = val - 1;
                Dstart.Value = rd.GetDateTime(4);
                Dend.Value = rd.GetDateTime(5);

            }

            sqlConnect.Close();
            sqlConnect.Open();
            List<status> stat = new List<status>();
            SqlCommand logRequstspel = new SqlCommand("Select * from Status", sqlConnect);
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
