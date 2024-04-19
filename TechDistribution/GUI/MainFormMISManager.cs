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
    public partial class MainFormMISManager : Form
    {
        public MainFormMISManager()
        {
            InitializeComponent();
        }

        private void buttonToEmployee_Click(object sender, EventArgs e)
        {
            Form employeeForm = new EmployeeManagement(this);

            employeeForm.Show();
            Hide();
        }

        private void buttonToUserAccount_Click(object sender, EventArgs e)
        {
            Form userAccounts = new UserAccountsManagement(this);

            userAccounts.Show();
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
