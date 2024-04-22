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
    public partial class MISController : Form
    {
        public MISController()
        {
            InitializeComponent();
        }

        EmployeeManagement employeeManagementForm;
        UserAccountsManagement userAccountsManagementForm;
        Login loginForm;


        private void buttonEmployeeManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeManagement employeeManagementForm = new EmployeeManagement();
            employeeManagementForm.Show();
        }

        private void buttonUserAccountManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAccountsManagement userAccountsManagementForm = new UserAccountsManagement();
            userAccountsManagementForm.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
