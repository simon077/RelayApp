using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelayApp
{
    public partial class frmInput : Form
    {
        public frmInput()
        {
            InitializeComponent();

            dtpStartDate.MaxDate = DateTime.Today.AddYears(1);
        
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(dtpStartDate.Value >= DateTime.Today)
            {
                frmDriver f1 = new frmDriver(nudNumberOfDrivers, dtpStartDate);
                f1.Show();
            }
            else
            {
                MessageBox.Show("You can not specify a start date before today", "Error");
            }


        }
    }
}
