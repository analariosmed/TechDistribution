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
    public partial class Login : Form
    {
        SqlDataAdapter dataAdapter;
        DataSet TechDistributionDB;
        DataTable dtCustomers;
        SqlCommandBuilder sqlCommandBuilder;

        MISController misControllerForm;
        CustomerMaintenance customerMaintenanceForm;
        InventoryController inventoryControllerForm;
        OrderManagement orderManagementForm;
        UserAccountsManagement userAccountManagementForm;

        public Login()
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
                        this.Hide();
                        Form form = new MISController();
                        form.Show();
                    }
                    else if (employee.JobId == 2)
                    {
                        this.Hide();
                        Form form = new CustomerMaintenance();
                        form.Show();
                    }
                    else if (employee.JobId == 3)
                    {
                        this.Hide();
                        Form form = new InventoryController();
                        form.Show();
                    }
                    else if (employee.JobId == 4)
                    {
                        this.Hide();
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
            this.Hide();
            Form form = new UserAccountsManagement();
            form.Show();
        }
        }
    }
    

