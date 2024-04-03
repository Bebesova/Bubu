using Microsoft.SqlServer.Server;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace repair
{
    public partial class Manager_menu : Form
    {
        int id_us;
        int i;
        public Manager_menu(int id_user)
        {
            id_us = id_user;
            InitializeComponent();
        }
        static string connString = @" Data Source=MEPHI3-MSSQL;Initial Catalog = ""praktika sentsova""; Integrated Security = True";
        SqlConnection sqlConnect = new SqlConnection(connString);
        int Order_id ;
        int Problem_id;
        int count=0 ;
        private void Manager_menu_Load(object sender, EventArgs e)
        {
            // таблица заявок
            SqlCommand Order = new SqlCommand();
            Order.CommandText = $"SELECT * FROM statement";
            Order.Connection = sqlConnect;
            SqlDataAdapter adapter = new SqlDataAdapter(Order);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            employeesDG.DataSource = dataSet.Tables[0];
            employeesDG.Columns[0].Visible = false;

            // таблицат проблемок
            SqlCommand Problem = new SqlCommand();
            Problem.CommandText = $"Select* from [dbo].[problem] ";
          
            
            Problem.Connection = sqlConnect;
            SqlDataAdapter Opopop = new SqlDataAdapter(Problem);
            DataSet dataSetp = new DataSet();
            Opopop.Fill(dataSetp);
            DGProblem.DataSource = dataSetp.Tables[0];
            DGProblem.Columns[0].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            //фильтр заявок
            switch (CBfilterStatus.SelectedIndex)
            {
                case 0:
                    (employeesDG.DataSource as DataTable).DefaultView.RowFilter = $"[Status] = 'Не начато ";
                    break;
                case 1:
                    (employeesDG.DataSource as DataTable).DefaultView.RowFilter = $"[Status] = 'В работе' ";
                    break;
                case 2:
                    (employeesDG.DataSource as DataTable).DefaultView.RowFilter = $"[Status] >= 'Выполнен'";
                    break;
                case 3:
                    (employeesDG.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            NewProblem rm = new NewProblem(Order_id);
            rm.ShowDialog();
        }

        private void employeesDG_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            count = 1;
            Order_id = Convert.ToInt32(employeesDG.Rows[e.RowIndex].Cells[0].Value);
            
        }

        

        private void BEdit_Click(object sender, EventArgs e)
        {
            EditOrder rm = new EditOrder(Order_id);
            rm.ShowDialog();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Problem_id = Convert.ToInt32(DGProblem.Rows[e.RowIndex].Cells[0].Value);
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NewExecutor fr = new NewExecutor(Problem_id);
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProblem edform = new EditProblem(Problem_id);
                edform.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Аuth form = new Аuth();
            this.Hide();
            form.ShowDialog();
        }

        private void BEditStatus_Click(object sender, EventArgs e)
        {
            // изменения статуса заявки
            sqlConnect.Open();
            SqlCommand editstat = new SqlCommand();
            editstat.Connection = sqlConnect;
            editstat.CommandType = CommandType.StoredProcedure;
            editstat.CommandText = "EdStatusOrder";

            editstat.Parameters.AddWithValue("@id_status", CBStatus.SelectedIndex);
        }

        private void employeesDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            sqlConnect.Open();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage reportExcel = new ExcelPackage();
            ExcelWorksheet excelWorkSheet = reportExcel.Workbook.Worksheets.Add("NewFile");
            excelWorkSheet.Cells["A1:F1"].Style.Border.BorderAround(ExcelBorderStyle.Thick); excelWorkSheet.Cells["A1:F1"].Style.Font.Bold = true;
            //excelWorkSheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;            excelWorkSheet.Cells["A1"].Value = "Заказ";
            excelWorkSheet.Cells["B1"].Value = "Устрйство";
            excelWorkSheet.Cells["C1"].Value = "Проблема";
            excelWorkSheet.Cells["D1"].Value = "ФИО исполнителя";
            excelWorkSheet.Cells["E1"].Value = "Дата начала работы";
            excelWorkSheet.Cells["F1"].Value = "Дата окончания работ";
            SqlCommand prob = new SqlCommand($"select * from XSLtable "); prob.Connection = sqlConnect;
            SqlDataReader rd = prob.ExecuteReader(); while (rd.Read())
            {
                i++;
                excelWorkSheet.Cells[$"A{i}"].Value = rd["equipment"].ToString();
                excelWorkSheet.Cells[$"B{i}"].Value = rd["desctiption"].ToString();
                excelWorkSheet.Cells[$"C{i}"].Value = rd["Expr1"].ToString();
                excelWorkSheet.Cells[$"D{i}"].Value = rd["name"].ToString();
                DateTime dstat = rd.GetDateTime(5);
                excelWorkSheet.Cells[$"E{i}"].Style.Numberformat.Format = "yyyy-mm-dd";

                excelWorkSheet.Cells[$"E{i}"].Value = dstat; excelWorkSheet.Cells[$"F{i}"].Value = dstat;

            }

            reportExcel.SaveAs(new FileInfo("D:\\NewFile.xlsx")); MessageBox.Show("Новый файл сохранен на диск D");
            i = 1;
            sqlConnect.Close(); */


        }
    }
}
