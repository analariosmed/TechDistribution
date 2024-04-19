using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.GUI;
using TechDistribution.BLL;
using TechDistribution.DAL;
using TechDistribution.VALIDATION;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace TechDistribution
{
    public partial class CustomerLogin : Form
    {
        SqlDataAdapter dataAdapter;
        DataSet TechDistributionDB;
        DataTable dtCustomers;
        SqlCommandBuilder sqlCommandBuilder;
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserId = Convert.ToInt32(textBoxUserID.Text.Trim());
            user.Password = textBoxPassword.Text.Trim();
            try
            {
                User userLoggedIn = User.CheckPassword(user);
                if (userLoggedIn != null)
                {
                    Employee employee = EmployeeDB.GetEmployeeByID(userLoggedIn.EmployeeId);
                    if (employee == null)
                    {
                        MessageBox.Show("employee not found User ID");
                        return;
                    }
                    if (employee.JobId == 1)
                    {
                        Form form = new EmployeeManagement();
                        form.Show();
                    }
                    else if (employee.JobId == 2)
                    {
                        Form form = new CustomerMaintenance();
                        form.Show();
                    }
                    else if (employee.JobId == 3)
                    {
                        //Form form = new ();
                        //form.Show();
                        MessageBox.Show("Under Construction");
                    }
                    else if (employee.JobId == 4)
                    {
                        Form form = new OrderManagement();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("No job found");
                    }
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error during login : "+ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new UserAccountsManagement();
            form.Show();
        }

        private void textBoxUserID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
