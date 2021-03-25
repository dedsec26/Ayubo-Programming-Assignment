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

namespace Ayubo_Programming_Assignment
{
    public partial class frmRent : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=Aflal-PC;Initial Catalog=ayubodrive;Integrated Security=True");
        private void combo()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select reg_no from vehicle", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboReg.DataSource = dataTable;
            comboReg.DisplayMember = "reg_no";
            comboReg.ValueMember = "reg_no";
        }
        public frmRent()
        {
            InitializeComponent();
        }

        private void txtNDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime start, end;
            TimeSpan ts;
            int days, months, weeks, finaldays,remainder;
            start = DateTime.Parse(dtimeStart.Text);
            end = DateTime.Parse(dtimeEnd.Text);
            ts = end - start;
            days = ts.Days;
            //days = (end - start);
            txtTdays.Text = days.ToString();
            months = (days / 30);
            txtNMonths.Text = (months).ToString();
            remainder = days - (months * 30);
            weeks = remainder / 7;
            txtNWeeks.Text = (weeks).ToString();
            finaldays = remainder % 7;
            txtNDays.Text =(finaldays).ToString();
            



        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            string sql_retrieve = "select * from vehicle where reg_no = '" + comboReg.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(sql_retrieve, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            txtDay.Text = dataReader["rt_day"].ToString();
            txtDriver.Text = dataReader["rt_driver"].ToString();
            txtModel.Text = dataReader["model"].ToString();
            txtMonth.Text = dataReader["rt_month"].ToString();
            txtType.Text = dataReader["type"].ToString();
            txtWeek.Text = dataReader["rt_week"].ToString();
            sqlConnection.Close();
            //txtReg.Enabled = false;
            txtType.Enabled = false;

            txtModel.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            combo();
            txtType.Enabled = false;
            txtModel.Enabled = false;
            txtDay.Enabled = false;
            txtDriver.Enabled = false;
            txtMonth.Enabled = false;
            txtWeek.Enabled = false;
            txtTdays.Enabled = false;
            txtNWeeks.Enabled = false;
            txtNMonths.Enabled = false;
            txtNDays.Enabled = false;
            txtTotal.Enabled = false;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            txtType.Enabled = false;
            txtModel.Enabled = false;
            txtDay.Enabled = false;
            txtDriver.Enabled = false;
            txtMonth.Enabled = false;
            txtWeek.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDay.Text) | string.IsNullOrEmpty(txtNMonths.Text) | string.IsNullOrEmpty(txtMonth.Text) | string.IsNullOrEmpty(txtNDays.Text) | 
                string.IsNullOrEmpty(txtWeek.Text) | string.IsNullOrEmpty(txtNWeeks.Text) | string.IsNullOrEmpty(txtTdays.Text) | string.IsNullOrEmpty(txtDriver.Text))
            {
                MessageBox.Show("Please Select Number of Days and Vehicle to be Rented.");
            }
            else
            {
                double total;
                double nmonths = Convert.ToDouble(txtNMonths.Text);
                double month = Convert.ToDouble(txtMonth.Text);
                double ndays = Convert.ToDouble(txtNDays.Text);
                double day = Convert.ToDouble(txtDay.Text);
                double week = Convert.ToDouble(txtWeek.Text);
                double nweek = Convert.ToDouble(txtNWeeks.Text);
                double tday = Convert.ToDouble(txtTdays.Text);
                double driver = Convert.ToDouble(txtDriver.Text);
                if (chkDrvr.Checked == true)
                {
                    total = (nmonths * month) + (ndays * day) + (week * nweek) + (tday * driver);
                    txtTotal.Text = total.ToString();

                }
                else
                {
                    total = (nmonths * month) + (ndays * day) + (week * nweek);
                    txtTotal.Text = total.ToString();
                }
            }
            
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
