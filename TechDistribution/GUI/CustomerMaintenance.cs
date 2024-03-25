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

        }


        private void buttonModify_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(textBoxCustomerId.Text);
            DataRow drCustomer = dtCustomers.Rows.Find(searchId);
            drCustomer["CustomerName"] = textBoxName.Text.Trim();
            drCustomer["Street"] = textBoxStreet.Text.Trim();
            drCustomer["City"] = textBoxCity.Text.Trim();
            drCustomer["PostalCode"] = textBoxPostalCode.Text.Trim();
            drCustomer["PhoneNumber"] = textBoxPhoneNumber.Text.Trim();
            drCustomer["FaxNumber"] = textBoxFaxNumber.Text.Trim();
            drCustomer["CreditLimit"] = textBoxCreditLimit.Text.Trim();


            MessageBox.Show("The RowState in the DataTable Customers : " + drCustomer.RowState, "RowState");
        }

        private void CustomerMaintenance_Load(object sender, EventArgs e)
        {
          
            TechDistributionDB = new DataSet("TechDistributionDS");
            dtCustomers = new DataTable("Customers");
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
            dtCustomers.Columns.Add("CreditLimit", typeof(int));

            // Set AllowDBNull property to true for the FaxNumber column
            dtCustomers.Columns["FaxNumber"].AllowDBNull = true;

            dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerId"] };
            dtCustomers.Columns["CustomerId"].AutoIncrement = true;
            dtCustomers.Columns["CustomerId"].AutoIncrementSeed = 1;
            dtCustomers.Columns["CustomerId"].AutoIncrementStep = 1;

            dataAdapter = new SqlDataAdapter();
            dataAdapter.TableMappings.Add("Customers", "Customers");
            sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {

            dataAdapter.Update(TechDistributionDB, "Customers");
            MessageBox.Show("Database has beeen update sucessfully.", "Database update");
        }

        private void buttonDS_Click(object sender, EventArgs e)
        {
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Customers", UtilityDB.GetDBConnection());
            dataAdapter.Fill(TechDistributionDB, "Customers");
            foreach (DataRow row in TechDistributionDB.Tables["Customers"].Rows)
            {
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

        private void buttonDB_Click(object sender, EventArgs e)
        {
            listViewDB.Items.Clear();

            List<Customer> customersList = new Customer().GetCustomers();

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
                listViewDB.Items.Add(item);
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            Customer customer = new Customer();


            //validation missing


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
            //dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Customers", UtilityDB.GetDBConnection());
            //dataAdapter.Fill(TechDistributionDB, "Customers");
            // dataAdapter.UpdateCommand.ExecuteNonQuery();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Customers", UtilityDB.GetDBConnection());
            dataAdapter.Fill(TechDistributionDB, "Customers");
            dataAdapter.Update(TechDistributionDB, "Customers");
            MessageBox.Show("Database has beeen update sucessfully.", "Database update");
        }

        private void ButtonSearch_Click_1(object sender, EventArgs e)
        {
            //INPUT data validation
            int customerId = Convert.ToInt32(textBoxCustomerId.Text.Trim());
            bool found = false;
            foreach (DataRow dr in dtCustomers.Rows)
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

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            //search operation first found it
            int searchId = Convert.ToInt32(textBoxCustomerId.Text);
            DataRow drCustomers = dtCustomers.Rows.Find(searchId);
            drCustomers.Delete();
            MessageBox.Show("The RowState in the DataTable Customers : " + drCustomers.RowState, "RowState");
        }

        private void buttonListAll_Click(object sender, EventArgs e)
        {

        }
    }
}
