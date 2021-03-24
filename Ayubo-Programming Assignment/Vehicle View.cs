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
   
    public partial class frmVehicleView : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=Aflal-PC;Initial Catalog=ayubodrive;Integrated Security=True");
        public frmVehicleView()
        {
            InitializeComponent();
        }
        private void combo()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select reg_no from vehicle", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboReg.DataSource = dataTable;
            comboReg.DisplayMember = "reg_no";
            comboReg.ValueMember = "reg_no";
        }
        private void clear()
        {
            txtDay.Clear();
            txtDriver.Clear();
            txtModel.Clear();
            txtMonth.Clear();
            //txtReg.Clear();
            txtType.Clear();
            txtWeek.Clear();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
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
               


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Vehicle_View_Load(object sender, EventArgs e)
        {
            combo();
            txtType.Enabled = false;
            txtDay.Enabled = false;
            txtWeek.Enabled = false;
            txtMonth.Enabled = false;
            txtDriver.Enabled = false;
            txtModel.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
