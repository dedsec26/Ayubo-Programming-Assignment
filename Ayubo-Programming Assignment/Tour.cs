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
    public partial class frmTour : Form
    {
        public frmTour()
        {
            InitializeComponent();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            frmDayTour frmDayTour = new frmDayTour();
            frmDayTour.Show();
            Dispose();
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            frmLongTour frmLongTour = new frmLongTour();
            frmLongTour.Show();
            Dispose();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
