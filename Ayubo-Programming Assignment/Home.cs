using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_Programming_Assignment
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            
            frmVehicle frmVehicle = new frmVehicle();
            
            //Hide();
            this.Dispose(false);
            //frmVehicle.FormClosed += (s, args) => this.Close();
            //Application.Exit;
            frmVehicle.Show();

        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            frmPackage frmPackage = new frmPackage();
            frmPackage.Show();
            Dispose();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            frmRent frmRent = new frmRent();
            frmRent.Show();
            //Hide();
            Dispose();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            frmTour frmTour = new frmTour();
            frmTour.Show();
            //Hide();
            Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
