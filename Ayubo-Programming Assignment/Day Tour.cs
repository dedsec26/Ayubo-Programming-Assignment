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
    public partial class frmDayTour : Form

    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=Aflal-PC;Initial Catalog=ayubodrive;Integrated Security=True");
        private void clear()
        {
            txtPKName.Clear();
            txtPKRt.Clear();
            txtVHType.Clear();
            txtMxDist.Clear();
            txtXtrDist.Clear();
            //txtDrN.Clear();
            //txtVhN.Clear();
           //txtTdays.Clear();
            txtTKm.Clear();
            txtXtrKm.Clear();
            //txtPKCost.Clear();
            //txtNightCost.Clear();
            txtKmCost.Clear();
            //txtTotal.Clear();
            txtEndRd.Clear();
            txtMxDur.Clear();
            txtXtrDur.Clear();
            txtCostXt.Clear();
            txtKmCost.Clear();
            txtNHrs.Clear();
            txtXHrs.Clear();
            txtTotalCost.Clear();


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
            //txtDrN.Enabled = false;
            //txtVhN.Enabled = false;
            txtNHrs.Enabled = false;
            txtCostXt.Enabled = false;
            txtXHrs.Enabled = false;
            txtTKm.Enabled = false;
            txtXtrKm.Enabled = false;
            txtKmCost.Enabled = false;
            txtTotalCost.Enabled = false;
        }
        public frmDayTour()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                //txtDrN.Text = dataReader["driver_night_rate"].ToString();
                //txtVhN.Text = dataReader["vehicle_night_rate"].ToString();
                sqlConnection.Close();
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                sqlConnection.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            combo();
            disable();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime start, end;
            TimeSpan ts;
            int hours, max, extra;
            double excost, cost;
            if (string.IsNullOrEmpty(txtXtrDur.Text) | string.IsNullOrEmpty(txtMxDur.Text))
            {
                MessageBox.Show("Please Select a Package Before Calculating Duration Cost.");
            }
            else
            {
                start = DateTime.Parse(dtimeStart.Text);
                end = DateTime.Parse(dtimeEnd.Text);
                ts = end - start;
                hours = ts.Hours;
                txtNHrs.Text = hours.ToString();
                max = Int32.Parse(txtMxDur.Text);
                excost = Double.Parse(txtXtrDur.Text);
                if (hours > max)
                {
                    extra = hours - max;
                    txtXHrs.Text = extra.ToString();
                    cost = extra * excost;
                    txtCostXt.Text = cost.ToString();

                }
                else if (hours < 0)
                {
                    hours = 0;
                    txtNHrs.Text = hours.ToString();
                    cost = 0;
                    txtCostXt.Text = cost.ToString();
                    extra = 0;
                    txtXHrs.Text = extra.ToString();
                }
                else
                {


                    cost = 0;
                    txtCostXt.Text = cost.ToString();
                    extra = 0;
                    txtXHrs.Text = extra.ToString();
                }
            }
            

            

            //days = (end - start);
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtXHrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKMCal_Click(object sender, EventArgs e)
        {
            int start, end, max, extra, current;
            double excost,finex;
            if (string.IsNullOrEmpty(txtMxDist.Text) | string.IsNullOrEmpty(txtXtrDist.Text))
            {
                MessageBox.Show("Please Select a Package Before Calculating Distance Cost");
            }
            else
            {
                if (string.IsNullOrEmpty(txtStRd.Text))
                {
                    start = 0;
                }
                else
                {
                    start = Int16.Parse(txtStRd.Text);
                }
                //start = Int16.Parse(txtStRd.Text);
                end = Int16.Parse(txtEndRd.Text);
                max = Int16.Parse(txtMxDist.Text);
                current = end - start;
                txtTKm.Text = current.ToString();
                excost = Double.Parse(txtXtrDist.Text);

                if (current > max)
                {
                    extra = current - max;
                    finex = extra * excost;
                    txtXtrKm.Text = extra.ToString();
                    txtKmCost.Text = finex.ToString();
                }
                else if (current < 0 | current < max)
                {
                    current = 0;
                    txtTKm.Text = current.ToString();
                    finex = 0;
                    txtKmCost.Text = finex.ToString();
                    extra = 0;
                    txtXtrKm.Text = extra.ToString();

                }
                else 
                {
                    finex = 0;
                    txtKmCost.Text = finex.ToString();
                    extra = 0;
                    txtXtrKm.Text = extra.ToString();
                }
            }
            

        }

        private void txtXtrKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTotalCost_Click(object sender, EventArgs e)
        {
            double package, hours, kms , final;
            if (string.IsNullOrEmpty(txtPKRt.Text) | string.IsNullOrEmpty(txtCostXt.Text) | string.IsNullOrEmpty(txtKmCost.Text))
            {
                MessageBox.Show("Please Select Package, Duration and Distance Before Calculating Total Cost.");
            }
            else
            {
                package = Double.Parse(txtPKRt.Text);
                hours = Double.Parse(txtCostXt.Text);
                kms = Double.Parse(txtKmCost.Text);
                final = package + hours + kms;
                txtTotalCost.Text = final.ToString();
            }

        }

        private void dtimeStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmTour frmTour = new frmTour();
            frmTour.Show();
            Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
