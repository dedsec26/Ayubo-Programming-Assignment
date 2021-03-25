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
    public partial class frmPackageView : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=Aflal-PC;Initial Catalog=ayubodrive;Integrated Security=True");
        public frmPackageView()
        {
            InitializeComponent();
        }

        private void frmPackageView_Load(object sender, EventArgs e)
        {
            combo();
            disable();
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
        private void disable()
        {
            txtPKName.Enabled = false;
            txtVHType.Enabled = false;
            txtPKRt.Enabled = false;
            txtMxDist.Enabled = false;
            txtMxDur.Enabled = false;
            txtXtrDist.Enabled = false;
            txtXtrDur.Enabled = false;
            txtDrN.Enabled = false;
            txtVhN.Enabled = false;
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
                //txtPKName.Enabled = false;
                //txtVHType.Enabled = false;
                //txtPKRt.Enabled = false;
                //txtMxDist.Enabled = false;
                //txtMxDur.Enabled = false;
                //txtXtrDist.Enabled = false;
                //txtXtrDur.Enabled = false;
                //txtDrN.Enabled = false;
                //txtVhN.Enabled = false;


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
