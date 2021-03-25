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
    public partial class frmPackageAdd : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=Aflal-PC;Initial Catalog=ayubodrive;Integrated Security=True");
        public frmPackageAdd()
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

        private void btnPKInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPKName.Text) | string.IsNullOrEmpty(txtVHType.Text) | string.IsNullOrEmpty(txtPKRt.Text) | string.IsNullOrEmpty(txtMxDist.Text) | 
                    string.IsNullOrEmpty(txtMxDur.Text) | string.IsNullOrEmpty(txtXtrDist.Text) | string.IsNullOrEmpty(txtXtrDur.Text) | string.IsNullOrEmpty(txtDrN.Text) | 
                    string.IsNullOrEmpty(txtVhN.Text))
                {
                    MessageBox.Show("Please fill in all the fields before adding a new Package.");
                }
                else
                {
                    string sql_insert = "insert into package values ('" + txtPKName.Text + "','" + txtVHType.Text + "','" + txtPKRt.Text + "'," +
               "'" + txtMxDist.Text + "','" + txtMxDur.Text + "','" + txtXtrDist.Text + "','" + txtXtrDur.Text + "','" + txtDrN.Text + "','" + txtVhN.Text + "')";
                    SqlCommand sqlCommand = new SqlCommand(sql_insert, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Package successfully added");
                    clear();
                    sqlConnection.Close();
                    //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id from package", sqlConnection);
                    //DataTable dataTable = new DataTable();
                    //sqlDataAdapter.Fill(dataTable);
                    //comboPkID.DataSource = dataTable;
                    //comboPkID.DisplayMember = "id";
                    //comboPkID.ValueMember = "id";
                    //sqlConnection.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                sqlConnection.Close();
            }
        }

        private void btnPKClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmPackage frmPackage = new frmPackage();
            frmPackage.Show();
            Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
