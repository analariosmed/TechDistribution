﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.GUI;

namespace TechDistribution.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            EmployeeManagement formEmployee = new EmployeeManagement();
            this.Hide();
            formEmployee.Show();

        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            UserAccountsManagement formUserAccount = new UserAccountsManagement();
            this.Hide();
            formUserAccount.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMaintenance formCustomers = new CustomerMaintenance();
            this.Hide();
            formCustomers.Show();

        }
    }
}
