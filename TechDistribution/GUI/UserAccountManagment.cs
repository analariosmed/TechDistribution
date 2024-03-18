using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TechDistribution.BLL;
using TechDistribution.DAL;
using TechDistribution.VALIDATION;

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
            user.Password = textBoxNewPassword.Text;
            bool value=User.UpdateUser(user);
            if (value==true)
            {
                MessageBox.Show("Password has been update sucessfully!");
            }
            
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

            int employeeId = Convert.ToInt32(textBoxEmployeeId.Text);


            try
            {
                Employee employee = new Employee();
                employee = employee.SearchEmployee(employeeId);
                textBoxFirstName.Text = employee.FirstName;
                textBoxLastName.Text = employee.LastName;
                textBoxEmail.Text = employee.Email;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, we didn't find an employee with that ID.");

            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Password = textBoxPassword.Text.Trim();
            user.StatusId = 0;
            user.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text);

            try
            {
                user.CreateUserAccount(user);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error to Create the User Account");
                return;
            }

            textBoxPassword.Clear();
            textBoxPassword2.Clear();
           

            MessageBox.Show("The User Account was created Sucessfully");

            int employeeId = Convert.ToInt32(textBoxEmployeeId.Text);
            User user1 = new User();

            try
            {
                user1 = user.SearchUserByEmployeeId(employeeId);
                if (user1 == null) 
                {
                    MessageBox.Show("Sorry, something was wrong getting your Information.");
                    
                }
                string firstName = user1.FirstName;
                string lastName = user1.LastName;
                int userId = user1.UserId;
                string dateCreated = user.DateCreated;  

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, something was wrong getting your information.");

            }

            labelInfo.Text = user1.FirstName + " " + user1.LastName + "\n"+
                            "Your Account was created successfully!!\n" +
                             "Your User Id is " + user1.UserId.ToString();
        }

  
    }
}
