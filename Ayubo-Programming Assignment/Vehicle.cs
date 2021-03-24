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
    public partial class frmVehicle : Form
    {
        public frmVehicle()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            Dispose();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmVehicleAdd frmVehicleAdd = new frmVehicleAdd();
            frmVehicleAdd.Show();
            Dispose();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmVehicleView frmVehicleView = new frmVehicleView();
            frmVehicleView.Show();
            Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmVehicleEdit frmVehicleEdit = new frmVehicleEdit();
            frmVehicleEdit.Show();
            Dispose();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
