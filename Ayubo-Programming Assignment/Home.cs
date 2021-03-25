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
            frmVehicle.MdiParent = this;
            //Hide();
            //this.Dispose(false);
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

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehicleView frmVehicleView = new frmVehicleView();
            frmVehicleView.MdiParent = this;
            frmVehicleView.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehicleEdit frmVehicleEdit = new frmVehicleEdit();
            frmVehicleEdit.MdiParent = this;
            frmVehicleEdit.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehicleAdd frmVehicleAdd = new frmVehicleAdd();
            frmVehicleAdd.MdiParent = this;
            frmVehicleAdd.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPackageView frmPackageView = new frmPackageView();
            frmPackageView.MdiParent = this;
            frmPackageView.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPackageEdit frmPackageEdit = new frmPackageEdit();
            frmPackageEdit.MdiParent = this;
            frmPackageEdit.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPackageAdd frmPackageAdd = new frmPackageAdd();
            frmPackageAdd.MdiParent = this;
            frmPackageAdd.Show();
        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRent frmRent = new frmRent();
            frmRent.MdiParent = this;
            frmRent.Show();
        }

        private void dayTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDayTour frmDayTour = new frmDayTour();
            frmDayTour.MdiParent = this;
            frmDayTour.Show();
        }

        private void longTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLongTour frmLongTour = new frmLongTour();
            frmLongTour.MdiParent = this;
            frmLongTour.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Application Will be Closed!", "Warning!" , MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dddd dd - MM - yyyy hh:mm");
            //txtTime.Text = DateTime.Now.ToString("dddd dd - MM - yyyy hh:mm");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Application Will be Closed!", "Warning!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
