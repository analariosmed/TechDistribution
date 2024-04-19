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
    public partial class OrderClerksMainForm : Form
    {
        public OrderClerksMainForm()
        {
            InitializeComponent();
        }

        /*
        private void buttonToCustomerMaintenance_Click(object sender, EventArgs e)
        {
            Form CusMaint = new CustomerMaintenance(this);
            CusMaint.Show();
            Close();
        }
        */

        private void buttonToOrders_Click(object sender, EventArgs e)
        {
            Form Orders = new OrderManagement(this);
            Orders.Show();
            Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
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
