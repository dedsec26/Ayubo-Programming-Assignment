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
    public partial class frmPackageEdit : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=Aflal-PC;Initial Catalog=ayubodrive;Integrated Security=True");
        public frmPackageEdit()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtDrN.Clear();
            txtMxDist.Clear();
            txtMxDur.Clear();
            txtPKName.Clear();
            txtPKRt.Clear();
            txtVhN.Clear();
            txtVHType.Clear();
            txtXtrDist.Clear();
            txtXtrDur.Clear();
        }
        private void combo()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id from package", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboPkID.DataSource = dataTable;
            comboPkID.DisplayMember = "id";
            comboPkID.ValueMember = "id";
        }

        private void comboPkID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPKInsert_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string sql_insert = "insert into package values ('" + txtPKName.Text + "','" + txtVHType.Text + "','" + txtPKRt.Text + "'," +
            //   "'" + txtMxDist.Text + "','" + txtMxDur.Text + "','" + txtXtrDist.Text + "','" + txtXtrDur.Text + "','" + txtDrN.Text + "','" + txtVhN.Text + "')";
            //    SqlCommand sqlCommand = new SqlCommand(sql_insert, sqlConnection);
            //    sqlConnection.Open();
            //    sqlCommand.ExecuteNonQuery();
            //    MessageBox.Show("Package successfully added");
            //    clear();
            //    sqlConnection.Close();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id from package", sqlConnection);
            //    DataTable dataTable = new DataTable();
            //    sqlDataAdapter.Fill(dataTable);
            //    comboPkID.DataSource = dataTable;
            //    comboPkID.DisplayMember = "id";
            //    comboPkID.ValueMember = "id";
            //    sqlConnection.Close();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //    sqlConnection.Close();
            //}
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            combo();
            txtPKName.Enabled = false;
            txtVHType.Enabled = false;
        }

        private void btnPKDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this Package ?", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string sql_delete = "delete from package where id ='" + comboPkID.Text + "' ";
                    SqlCommand sqlCommand = new SqlCommand(sql_delete, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Package successfully deleted");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id from package", sqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    comboPkID.DataSource = dataTable;
                    comboPkID.DisplayMember = "id";
                    comboPkID.ValueMember = "id";
                    sqlConnection.Close();

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

        private void btnPKClear_Click(object sender, EventArgs e)
        {
            clear();
            txtPKName.Enabled = true;
            txtVHType.Enabled = true;
            txtPKRt.Enabled = true;
            txtMxDist.Enabled = true;
            txtMxDur.Enabled = true;
            txtXtrDist.Enabled = true;
            txtXtrDur.Enabled = true;
            txtDrN.Enabled = true;
            txtVhN.Enabled = true;
        }

        private void btnPKRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_retrieve = "select * from package where id = '" + comboPkID.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(sql_retrieve, sqlConnection);
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                txtPKName.Text = dataReader["name"].ToString();
                txtVHType.Text = dataReader["vehicle_type"].ToString();
                txtPKRt.Text = dataReader["rate"].ToString();
                txtMxDist.Text = dataReader["max_km"].ToString();
                txtMxDur.Text = dataReader["max_hours"].ToString();
                txtXtrDist.Text = dataReader["ex_km_rate"].ToString();
                txtXtrDur.Text = dataReader["ex_hours_rate"].ToString();
                txtDrN.Text = dataReader["driver_night_rate"].ToString();
                txtVhN.Text = dataReader["vehicle_night_rate"].ToString();
                sqlConnection.Close();
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                sqlConnection.Close();
            }
        }

        private void btnPKUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPKRt.Text) | string.IsNullOrEmpty(txtMxDist.Text) | string.IsNullOrEmpty(txtMxDur.Text) | string.IsNullOrEmpty(txtXtrDist.Text) | 
                    string.IsNullOrEmpty(txtXtrDur.Text) | string.IsNullOrEmpty(txtDrN.Text) | string.IsNullOrEmpty(txtVhN.Text))
                {
                    MessageBox.Show("Please fill in all the feilds before updating.");
                }
                else
                {
                    string sql_update = "update package set rate = '" + txtPKRt.Text + "', max_km = '" + txtMxDist.Text + "',max_hours = '" + txtMxDur.Text + "' " +
                 ", ex_hours_rate = '" + txtXtrDur.Text + "', driver_night_rate = '" + txtDrN.Text + "' , vehicle_night_rate = '" + txtVhN.Text + "' where id = '" + comboPkID.Text + "' ";
                    SqlCommand sqlCommand = new SqlCommand(sql_update, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Package rate successfully updated.");
                    clear();
                    sqlConnection.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                sqlConnection.Close();
            }
        }

        private void txtVhN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDrN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXtrDur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXtrDist_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMxDist_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPKRt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPKName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMxDur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVHType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmPackage frmPackage = new frmPackage();
            frmPackage.Show();
            Dispose();
        }
    }
}
