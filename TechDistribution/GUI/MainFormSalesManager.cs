using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechDistribution.GUI
{
    public partial class Sales_Manager : Form
    {
        public Sales_Manager()
        {
            InitializeComponent();
        }

        private void buttonToCustomerManagement_Click(object sender, EventArgs e)
        {
            Form customerManagement = new CustomerMaintenance(this);

            customerManagement.Show();
            Hide();
            
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("you're login out, are you sure?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Form login = new EmployeeLogin();
                login.Show();
                Close();
            }
        }
    }
}
