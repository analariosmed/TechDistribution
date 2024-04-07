using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.DAL;
using TechDistribution.BLL;
using TechDistribution.VALIDATION;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient; // WORK IN A DISCONNECTED MOODE



namespace TechDistribution.GUI
{
    public partial class CustomerMaintenance : Form
    {
        SqlDataAdapter dataAdapter;
        DataSet TechDistributionDB;
        DataTable dtCustomers;
        SqlCommandBuilder sqlCommandBuilder;
       

        public CustomerMaintenance()
        {
            InitializeComponent();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            string input;

            input = textBoxPhoneNumberUpdate.Text.Trim();

            if (!Validator.IsValidPhoneNumber(input))
            {
                MessageBox.Show("The Phone number  is not correct, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            input = textBoxCreditLimitUpdate.Text.Trim();
                
            if(!Validator.IsValidNumber(input))
            {
                MessageBox.Show("The Credit Limit  is not correct, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            int searchId = Convert.ToInt32(textBoxCustomerId.Text);
            DataRow drCustomer = dtCustomers.Rows.Find(searchId);
            drCustomer["CustomerName"] = textBoxNameUpdate.Text.Trim();
            drCustomer["Street"] = textBoxStreetUpdate.Text.Trim();
            drCustomer["City"] = textBoxCityUpdate.Text.Trim();
            drCustomer["PostalCode"] = textBoxPostalCodeUpdate.Text.Trim();
            drCustomer["PhoneNumber"] = textBoxPhoneNumberUpdate.Text.Trim();
            drCustomer["FaxNumber"] = textBoxFaxNumberUpdate.Text.Trim();
            drCustomer["CreditLimit"] = Convert.ToDecimal(textBoxCreditLimitUpdate.Text.Trim());


            MessageBox.Show("The RowState in the DataTable Customers : " + drCustomer.RowState, "RowState");
        }

        private void CustomerMaintenance_Load(object sender, EventArgs e)
        {
          
            TechDistributionDB = new DataSet("TechDistributionDS");
            dtCustomers = new DataTable("Customers");
            //fixing problem with the constrains
            TechDistributionDB.Tables.Clear();
            TechDistributionDB.EnforceConstraints = false;
            TechDistributionDB.Tables.Add(dtCustomers);

            dtCustomers.Columns.Add("CustomerId", typeof(int));
            dtCustomers.Columns.Add("CustomerName", typeof(string));
            dtCustomers.Columns.Add("Street", typeof(string));
            dtCustomers.Columns.Add("City", typeof(string));
            dtCustomers.Columns.Add("PostalCode", typeof(string));
            dtCustomers.Columns.Add("PhoneNumber", typeof(string));
            dtCustomers.Columns.Add("FaxNumber", typeof(string));
            dtCustomers.Columns.Add("CreditLimit", typeof(decimal));

            // Set Allow Null property fir  FaxNumber column
            dtCustomers.Columns["FaxNumber"].AllowDBNull = true;

            //set primaryKey and autoincrement for CustomerId
            dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerId"] };
            dtCustomers.Columns["CustomerId"].AutoIncrement = true;
            dtCustomers.Columns["CustomerId"].AutoIncrementSeed = 1;
            dtCustomers.Columns["CustomerId"].AutoIncrementStep = 1;

            dataAdapter = new SqlDataAdapter();
            dataAdapter.TableMappings.Add("Customers", "Customers");
            sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Customers", UtilityDB.GetDBConnection());
            dataAdapter.Fill(TechDistributionDB, "Customers");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            dataAdapter.Update(TechDistributionDB, "Customers");
            MessageBox.Show("Database has beeen update sucessfully.", "Database update");
        }

        private void buttonDS_Click(object sender, EventArgs e)
        {
            listViewDS.Items.Clear();
            ////dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Customers", UtilityDB.GetDBConnection());
            //dataAdapter.Fill(TechDistributionDB, "Customers");
            foreach (DataRow row in TechDistributionDB.Tables["Customers"].Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    continue;
                }
                ListViewItem item = new ListViewItem(row["CustomerId"].ToString()); 
                item.SubItems.Add(row["CustomerName"].ToString());
                item.SubItems.Add(row["Street"].ToString());
                item.SubItems.Add(row["City"].ToString());
                item.SubItems.Add(row["PostalCode"].ToString());
                item.SubItems.Add(row["PhoneNumber"].ToString());
                item.SubItems.Add(row["FaxNumber"].ToString());
                item.SubItems.Add(row["CreditLimit"].ToString());
                listViewDS.Items.Add(item);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string input;

            input = textBoxName.Text.Trim();

            if (!Validator.IsValidText(input))
            {
                MessageBox.Show("The Name is not correct, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            input = textBoxPhoneNumber.Text.Trim();

            if (!Validator.IsValidPhoneNumber(input))
            {
                MessageBox.Show("The Phone number  is not correct, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            input = textBoxCreditLimit.Text.Trim();

            if (!Validator.IsValidNumber(input))
            {
                MessageBox.Show("The Credit Limit  is not correct, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            DataRow dr = dtCustomers.NewRow();
            dr["CustomerName"] = textBoxName.Text.Trim();
            dr["Street"] = textBoxStreet.Text.Trim();
            dr["City"] = textBoxCity.Text.Trim();
            dr["PostalCode"] = textBoxPostalCode.Text.Trim();
            dr["PhoneNumber"] = textBoxPhoneNumber.Text.Trim();
            dr["FaxNumber"] = textBoxFaxNumber.Text.Trim();
            dr["CreditLimit"] = textBoxCreditLimit.Text.Trim();

            dtCustomers.Rows.Add(dr);
            MessageBox.Show(dr.RowState.ToString(), "RowState in DataTable Customers");


            textBoxName.Clear();
            textBoxStreet.Clear();
            textBoxCity.Clear();
            textBoxPostalCode.Clear();
            textBoxPhoneNumber.Clear();
            textBoxFaxNumber.Clear();
            textBoxCreditLimit.Clear();
        }

        private void buttonUpdateDB_Click(object sender, EventArgs e)
        {
          
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Customers", UtilityDB.GetDBConnection());
            dataAdapter.Fill(TechDistributionDB, "Customers");
            dataAdapter.Update(TechDistributionDB, "Customers");
            MessageBox.Show("Database has beeen update sucessfully.", "Database update");
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            //INPUT data validation
            int customerId = Convert.ToInt32(textBoxCustomerId.Text.Trim());
            bool found = false;
            foreach (DataRow dr in TechDistributionDB.Tables["Customers"].Rows)
            {
                if (Convert.ToInt32(dr["CustomerId"]) == customerId)
                {
                    textBoxNameUpdate.Text = dr["CustomerName"].ToString();
                    textBoxStreetUpdate.Text = dr["Street"].ToString();
                    textBoxCityUpdate.Text = dr["City"].ToString();
                    textBoxPostalCodeUpdate.Text = dr["PostalCode"].ToString();
                    textBoxPhoneNumberUpdate.Text = dr["PhoneNumber"].ToString();
                    textBoxFaxNumberUpdate.Text = dr["FaxNumber"].ToString();
                    textBoxCreditLimitUpdate.Text = dr["CreditLimit"].ToString();

                    found = true;
                    break;

                }
            }

            if (!found)
            {
                MessageBox.Show("Customer not found!", "Invalid Customer ID");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //search operation first found it
            int searchId = Convert.ToInt32(textBoxCustomerId.Text);
            DataRow drCustomers = TechDistributionDB.Tables["Customers"].Rows.Find(searchId);
            drCustomers.Delete();
            MessageBox.Show("The RowState in the DataTable Customers : " + drCustomers.RowState, "RowState");

        }

        private void buttonListAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            List<Customer> customersList = new Customer().GetCustomers();
           // dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Customers", UtilityDB.GetDBConnection());
            //dataAdapter.Fill(TechDistributionDB, "Customers");
            foreach (Customer customer in customersList)
            {
                ListViewItem item = new ListViewItem(customer.CustomerId.ToString());
                item.SubItems.Add(customer.Name);
                item.SubItems.Add(customer.Street);
                item.SubItems.Add(customer.City);
                item.SubItems.Add(customer.PostalCode);
                item.SubItems.Add(customer.PhoneNumber);
                item.SubItems.Add(customer.FaxNumber);
                item.SubItems.Add(customer.CreditLimit.ToString());
                listView1.Items.Add(item);
            }
        }

    }
}
