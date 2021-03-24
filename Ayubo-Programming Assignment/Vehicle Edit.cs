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
    public partial class frmVehicleEdit : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=Aflal-PC;Initial Catalog=ayubodrive;Integrated Security=True");
        public frmVehicleEdit()
        {
            InitializeComponent();
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
        private void combo()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select reg_no from vehicle", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboReg.DataSource = dataTable;
            comboReg.DisplayMember = "reg_no";
            comboReg.ValueMember = "reg_no";
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void frmVehicleEdit_Load(object sender, EventArgs e)
        {
            combo();
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
                txtType.Enabled = false;

                txtModel.Enabled = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtModel.Text) | string.IsNullOrEmpty(txtDay.Text) | string.IsNullOrEmpty(txtDriver.Text) | string.IsNullOrEmpty(txtModel.Text) |
                    string.IsNullOrEmpty(txtMonth.Text) | string.IsNullOrEmpty(txtWeek.Text))
                {
                    MessageBox.Show("Please fill all feilds before updating");
                }
                else
                {
                    string sql_update = "update vehicle set rt_day = '" + txtDay.Text + "', rt_month = '" + txtMonth.Text + "',rt_week = '" + txtWeek.Text + "' " +
                 ", rt_driver = '" + txtDriver.Text + "' where reg_no = '" + comboReg.Text + "' ";
                    SqlCommand sqlCommand = new SqlCommand(sql_update, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Vehicle rate successfully updated");
                    clear();
                    sqlConnection.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this Package ?", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string sql_delete = "delete from vehicle where reg_no ='" + comboReg.Text + "' ";
                    SqlCommand sqlCommand = new SqlCommand(sql_delete, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Package successfully deleted");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select reg_no from vehicle", sqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    comboReg.DataSource = dataTable;
                    comboReg.DisplayMember = "reg_no";
                    comboReg.ValueMember = "reg_no";
                    clear();

                }
                else
                {
                    clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            //txtReg.Enabled = true;
            txtType.Enabled = true;
            txtMonth.Enabled = true;
            txtWeek.Enabled = true;
            txtDriver.Enabled = true;
            txtModel.Enabled = true;
            txtDay.Enabled = true;
        }
    }
}
