using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.BLL;
using TechDistribution.DAL;
using TechDistribution.VALIDATION;
using TechDistribution.GUI;

namespace TechDistribution.GUI
{
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string text = textBoxUsername.Text.Trim();
            List<User> users = User.GetUsers();

            if (!MyValidator.IsValidID(text))
            {
                MessageBox.Show("Wrong Credentials1");
                return;
            }
            int userId = Convert.ToInt32(text);
            User userToFind = User.FindUserByUserID(userId);

            if (userToFind == null)
            {
                MessageBox.Show("Wrong Credentials2");
                return;
            }

            text = textBoxPassword.Text;

            if (text != userToFind.Password)
            {
                MessageBox.Show("Wrong Credentials3");
                return;
            }

            int jobIdToRedirect = userToFind.JobId;

            switch (jobIdToRedirect)
            {
                case 1://MIS Manager
                    Form misManager = new MainFormMISManager();
                    misManager.Show();
                    Hide();
                    break;
                case 2://Sales Manager
                    Form salesManager = new Sales_Manager();
                    salesManager.Show();
                    Hide();
                    break;
                case 3://Inventory Controller
                    Form inventoryController = new InventoryControllerMainForm();
                    inventoryController.Show();
                    Hide();
                    break;
                case 4://Order Clerk
                    Form orderClerk = new OrderClerksMainForm();
                    orderClerk.Show();
                    Hide();
                    break;
            }



        }

        //public EmployeeLogin()
        //{
        //    InitializeComponent();
        //    EmployeeManager.loadUsers();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (isValidMember())
        //    {
        //        Report ReportForm = new Report();
        //        ReportForm.Show();
        //        this.Hide();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Username or Password is not correct");
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    EmployeeAccount formAccount = new EmployeeAccount();
        //    formAccount.Show();
        //    this.Hide();
        //}
    }
}

