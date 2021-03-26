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
    public partial class frmLongTour : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=Aflal-PC;Initial Catalog=ayubodrive;Integrated Security=True");
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
            txtPKRt.Enabled = false;
            txtVHType.Enabled = false;
            txtMxDist.Enabled = false;
            txtXtrDist.Enabled = false;
            txtDrN.Enabled = false;
            txtVhN.Enabled = false;
            txtTdays.Enabled = false;
            txtTKm.Enabled = false;
            txtXtrKm.Enabled = false;
            txtPKCost.Enabled = false;
            txtNightCost.Enabled = false;
            txtKmCost.Enabled = false;
            txtTotal.Enabled = false;
        }
        private void clear()
        {
            txtPKName.Clear();
            txtPKRt.Clear();
            txtVHType.Clear();
            txtMxDist.Clear();
            txtXtrDist.Clear();
            txtDrN.Clear();
            txtVhN.Clear();
            txtTdays.Clear();
            txtTKm.Clear();
            txtXtrKm.Clear();
            txtPKCost.Clear();
            txtNightCost.Clear();
            txtKmCost.Clear();
            txtTotal.Clear();
            txtEndRd.Clear();
          
        }
        public frmLongTour()
        {
            InitializeComponent();
        }

        private void txtTdays_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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
                //txtMxDur.Text = dataReader["max_hours"].ToString();
                txtXtrDist.Text = dataReader["ex_km_rate"].ToString();
                //txtXtrDur.Text = dataReader["ex_hours_rate"].ToString();
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

        private void Form5_Load(object sender, EventArgs e)
        {
            combo();
            disable();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime start, end;
            TimeSpan ts;
            int days;
            double pk, pktotal, ndriver, nvehicle, ntotal;
            //months, weeks, finaldays, remainder;
            if (string.IsNullOrEmpty(dtimeStart.Text) | string.IsNullOrEmpty(dtimeEnd.Text))
            {
                MessageBox.Show("Please Select Number Of Days.");
            }
            else
            {
                start = DateTime.Parse(dtimeStart.Text);
                end = DateTime.Parse(dtimeEnd.Text);
                ts = end - start;
                days = ts.Days;
                if (days <= 0)
                {
                    txtTdays.Text = "0";
                    MessageBox.Show("Please insert Valid Dates");

                }
                else
                {

                    if (string.IsNullOrEmpty(txtPKRt.Text) | string.IsNullOrWhiteSpace(txtPKRt.Text))
                    {
                        MessageBox.Show("Please Select a Package Before Calculating Number of Days");
                    }
                    else
                    {
                        pk = Double.Parse(txtPKRt.Text);
                        pktotal = days * pk;
                        txtPKCost.Text = pktotal.ToString();
                        ndriver = Double.Parse(txtDrN.Text);
                        nvehicle = Double.Parse(txtVhN.Text);
                        ntotal = (ndriver + nvehicle) * (days - 1);
                        txtNightCost.Text = ntotal.ToString();
                        txtTdays.Text = days.ToString();
                    }
                }
            }
            
            
            
            
            
        }

        private void btnKMCal_Click(object sender, EventArgs e)
        {
            
            int start, end, max, extra, current, days, dayszero;
            double excost, finex;
            
            if (string.IsNullOrEmpty(txtTdays.Text))
            {
                MessageBox.Show("Please Select Duraion Before Calculating Distance.");
            }
            else
            {
                dayszero = Int16.Parse(txtTdays.Text);
                if (string.IsNullOrEmpty(txtTdays.Text) | string.IsNullOrWhiteSpace(txtTdays.Text))
                {
                    MessageBox.Show("Please Select Valid Dates Before Calculating Distance.");
                }
                else if (dayszero <= 0)
                {
                    MessageBox.Show("Please Select Valid Dates Before Calculating Distance.");
                }
                else
                {
                    if ((string.IsNullOrEmpty(txtStRd.Text)) | (string.IsNullOrWhiteSpace(txtStRd.Text)))
                    {
                        start = 0;
                    }
                    else
                    {
                        start = Int32.Parse(txtStRd.Text);
                    }
                    if ((string.IsNullOrEmpty(txtEndRd.Text)) | (string.IsNullOrWhiteSpace(txtEndRd.Text)))
                    {
                        MessageBox.Show("Please Enter Valid Journey End Meter Reading");
                    }
                    else
                    {
                        end = Int32.Parse(txtEndRd.Text);
                        if ((string.IsNullOrWhiteSpace(txtMxDist.Text)) | (string.IsNullOrEmpty(txtMxDist.Text)))
                        {
                            MessageBox.Show("Please Select a Package Before Calculating Distance");
                        }
                        else
                        {
                            max = Int16.Parse(txtMxDist.Text);
                            current = end - start;
                            txtTKm.Text = current.ToString();
                            excost = Double.Parse(txtXtrDist.Text);
                            if (string.IsNullOrEmpty(txtTdays.Text) | string.IsNullOrWhiteSpace(txtTdays.Text))
                            {
                                MessageBox.Show("Please Select Start and End Dates Before Calculating Distance");
                            }
                            else
                            {
                                days = Int16.Parse(txtTdays.Text);

                                if (current > (max * days))
                                {
                                    extra = current - (max * days);
                                    finex = extra * excost;
                                    txtXtrKm.Text = extra.ToString();
                                    txtKmCost.Text = finex.ToString();
                                }
                                else if (current < 0)
                                {
                                    current = 0;
                                    txtTKm.Text = current.ToString();
                                    finex = 0;
                                    txtKmCost.Text = finex.ToString();
                                    extra = 0;
                                    txtXtrKm.Text = extra.ToString();

                                }
                                else if (current < (max * days))
                                {
                                    extra = 0;
                                    finex = 0;
                                    txtXtrKm.Text = extra.ToString();
                                    txtKmCost.Text = finex.ToString();

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


                    }
                }
            }
            
            
            
            
        }

        private void txtXtrKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPKCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double pk, night, dist, total;
            if (string.IsNullOrEmpty(txtPKCost.Text) | string.IsNullOrWhiteSpace(txtPKCost.Text))
            {
                MessageBox.Show("Please Select Start and End Dates Before Calculating Total Cost");
            }
            else
            {
                pk = double.Parse(txtPKCost.Text);
                night = double.Parse(txtNightCost.Text);
                if (string.IsNullOrWhiteSpace(txtKmCost.Text) | string.IsNullOrEmpty(txtKmCost.Text))
                {
                    MessageBox.Show("Please Calculate Amount of Extra Distance Before Calculating Total Cost");
                }
                else
                {
                    dist = double.Parse(txtKmCost.Text);
                    total = pk + night + dist;
                    txtTotal.Text = total.ToString();
                }
                
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
