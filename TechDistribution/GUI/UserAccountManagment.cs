using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.BLL;
using TechDistribution.DAL;

namespace TechDistribution.GUI
{
    public partial class UserAccountManagment : Form
    {
        public UserAccountManagment()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxUserId.Text == "")
            {
                MessageBox.Show("Please select a User Id");
                return;
            }

            listView1.Items.Clear();
            User user = new User();
            int userId = Convert.ToInt32(textBoxUserId.Text);


            try
            {
                User user1 = user.SearchUser(userId);
                ListViewItem item = new ListViewItem(user1.UserId.ToString());
                item.SubItems.Add(user1.FirstName.ToString());
                item.SubItems.Add(user1.LastName.ToString());
                item.SubItems.Add(user1.DateCreated.ToString());
                item.SubItems.Add(user1.DateModified.ToString());
                item.SubItems.Add(user1.JobTitle.ToString());
                item.SubItems.Add(user1.StatusDesc.ToString());

                listView1.Items.Add(item);
            }
            catch
            {
                MessageBox.Show("Sorry! User don't found");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show($"Do you want to delete the UserAccount{textBoxUserId.Text}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                int id = Convert.ToInt32(textBoxUserId.Text);
                try
                {
                    Employee.DeleteEmployee(id);
                    MessageBox.Show("Success Delete", "Information");
                    listView1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There were a problem at delete the User Account" + ex.ToString());
                    return;
                }

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserId = Convert.ToInt32(textBoxUserId.Text);
            user.Password = textBoxEmployeeId.Text;
            User.UpdateUser(user);
            MessageBox.Show("Password has been update sucessfully!");
        }

        private void buttonListAll_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();

            users = User.GetUsers();

            listViewAllUsers.Items.Clear();

            foreach (User user in users)
            {
                ListViewItem row = new ListViewItem(user.UserId.ToString());
                row.SubItems.Add(user.FirstName);
                row.SubItems.Add(user.LastName);
                row.SubItems.Add(user.DateCreated);
                row.SubItems.Add(user.DateModified);        
                row.SubItems.Add(user.JobTitle);
                row.SubItems.Add(user.StatusDesc);

                listViewAllUsers.Items.Add(row);
            }
        }



        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {

            string text = textBoxEmployeeId.Text;
            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("Insert a valid Employee Id");
                return;
            }

            Employee newEmp = new Employee();

            try
            {
                Employee employee = Employee.SearchEmployee(text);
                ListViewItem item = new ListViewItem(employee.EmployeeId.ToString());
                item.SubItems.Add(employee.FirstName.ToString());
                item.SubItems.Add(employee.LastName.ToString());
 

                listView1.Items.Add(item);
            }
            catch
            {
                MessageBox.Show("Sorry! Employee don't found");
            }

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {

        }
    }
    
}
