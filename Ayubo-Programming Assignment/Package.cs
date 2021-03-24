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
    public partial class frmPackage : Form
    {
        public frmPackage()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmPackageAdd frmPackageAdd = new frmPackageAdd();
            frmPackageAdd.Show();
            Dispose();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmPackageView frmPackageView = new frmPackageView();
            frmPackageView.Show();
            Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmPackageEdit frmPackageEdit = new frmPackageEdit();
            frmPackageEdit.Show();
            Dispose();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
