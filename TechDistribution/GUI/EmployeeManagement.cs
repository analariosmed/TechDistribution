using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.DAL;
using TechDistribution.BLL;
using TechDistribution.VALIDATION;
using System.Windows.Forms;


namespace TechDistribution.GUI
{

    /// <summary>
    /// Represents a form for managing employees in the Tech Distribution system.
    /// </summary>
    public partial class EmployeeManagement : Form
    {
        
        Form prevForm;
        // Constructor
        public EmployeeManagement(Form previousForm)
        {
            InitializeComponent();
            comboBoxStatus.SelectedIndex = 0;
            comboBoxJobTitle.SelectedIndex = 0;
            comboBoxSearchBy.SelectedIndex = 0;

             prevForm = previousForm;


        }


        /// <summary>
        /// Clears all input fields and selection in the search section of the form.
        /// </summary>
        private void clearFields()
        {
            // Clears all textboxes and resets combobox selections in the search section.
            textBoxSearchEmployeeID.Clear();
            textBoxSearchFirstName.Clear();
            textBoxSearchLastName.Clear();
            textBoxSearchEmail.Clear();
            textBoxSearchPhoneNumber.Clear();
            comboBoxSearchStatus.SelectedIndex = -1;
            comboBoxSearchJobTitle.SelectedIndex = -1;
        }


        /// <summary>
        /// Handles searching for an employee by ID.
        /// </summary>
        private void SearchByID()
        {
            // Clears the search fields, validates the input ID, retrieves the employee details, and displays them in the search list view.

            clearFields();

            string id = textBoxSearchBy.Text.Trim();

            if (!MyValidator.IsValidID(id))
            {
                MessageBox.Show("The ID you wrote is not valid, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int realId = Convert.ToInt32(id);

            if (!Employee.IsAExistingEmployee(realId))
            {
                MessageBox.Show("The ID you wrote is not found, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee emp = new Employee();

            emp = EmployeeDB.GetEmployeeByID(realId);

            listViewSearch.Items.Clear();
            ListViewItem row = new ListViewItem(emp.EmployeeId.ToString());
            row.SubItems.Add(emp.FirstName);
            row.SubItems.Add(emp.LastName);
            row.SubItems.Add(emp.Email);
            row.SubItems.Add(emp.PhoneNumber);
            row.SubItems.Add(emp.StatusDesc);
            row.SubItems.Add(emp.JobTitle);

            listViewSearch.Items.Add(row);

            textBoxSearchEmployeeID.Text = emp.EmployeeId.ToString();
            textBoxSearchFirstName.Text = emp.FirstName;
            textBoxSearchLastName.Text = emp.LastName;
            textBoxSearchEmail.Text = emp.Email;
            textBoxSearchPhoneNumber.Text = emp.PhoneNumber;

            int idx = comboBoxSearchStatus.Items.IndexOf(emp.StatusDesc);

            comboBoxSearchStatus.SelectedIndex = idx;

            idx = comboBoxJobTitle.Items.IndexOf(emp.JobTitle);

            comboBoxSearchJobTitle.SelectedIndex = idx;

        }


        /// <summary>
        /// Handles searching for employees by first name.
        /// </summary>


        private void SearchByFirstName()
        {
            // Validates the input first name, searches for employees matching the first name, and displays them in the search list view.

            string text = textBoxSearchBy.Text;
            if (!MyValidator.IsValidText(text))
            {
                MessageBox.Show("The input you wrote is an incorrect format, try again");
                return;
            }

            List<Employee> employees = Employee.SearchByFirstName(text);

            if(employees.Count == 0)
            {
                MessageBox.Show("That First Name is not in our records");
                return;
            }

            clearFields();

            listViewSearch.Items.Clear();
            

            foreach (Employee emp in employees)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                item.SubItems.Add(emp.FirstName);
                item.SubItems.Add(emp.LastName);
                item.SubItems.Add(emp.Email);
                item.SubItems.Add(emp.PhoneNumber);
                item.SubItems.Add(emp.StatusDesc);
                item.SubItems.Add(emp.JobTitle);

                listViewSearch.Items.Add(item);
            }

        }

        /// <summary>
        /// Handles searching for employees by last name.
        /// </summary>
        private void SearchByLastName()
        {
            // Validates the input last name, searches for employees matching the last name, and displays them in the search list view.

            string text = textBoxSearchBy.Text;
            if (!MyValidator.IsValidText(text))
            {
                MessageBox.Show("The input you wrote is an incorrect format, try again");
                return;
            }

            List<Employee> employees = Employee.SearchByLastName(text);

            if (employees.Count == 0)
            {
                MessageBox.Show("That Last Name is not in our records");
                return;
            }

            clearFields();
            listViewSearch.Items.Clear();

            foreach (Employee emp in employees)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                item.SubItems.Add(emp.FirstName);
                item.SubItems.Add(emp.LastName);
                item.SubItems.Add(emp.Email);
                item.SubItems.Add(emp.PhoneNumber);
                item.SubItems.Add(emp.StatusDesc);
                item.SubItems.Add(emp.JobTitle);

                listViewSearch.Items.Add(item);
            }
        }

        /// <summary>
        /// Handles searching for employees by email.
        /// </summary>

        private void SearchByEmail()
        {
            // Validates the input email, searches for employees matching the email, and displays them in the search list view.

            string text = textBoxSearchBy.Text;
            if (!MyValidator.IsValidEmail(text))
            {
                MessageBox.Show("The input you wrote is an incorrect format, try again");
                return;
            }

            List<Employee> employees = Employee.SearchByEmail(text);

            if (employees.Count == 0)
            {
                MessageBox.Show("That Email is not in our records");
                return;
            }

            clearFields();
            listViewSearch.Items.Clear();

            foreach (Employee emp in employees)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                item.SubItems.Add(emp.FirstName);
                item.SubItems.Add(emp.LastName);
                item.SubItems.Add(emp.Email);
                item.SubItems.Add(emp.PhoneNumber);
                item.SubItems.Add(emp.StatusDesc);
                item.SubItems.Add(emp.JobTitle);

                listViewSearch.Items.Add(item);
            }
        }


        /// <summary>
        /// Handles searching for employees by phone number.
        /// </summary>

        private void SearchByPhoneNumber()
        {
            // Validates the input phone number, searches for employees matching the phone number, and displays them in the search list view.

            string text = textBoxSearchBy.Text;
            if (!MyValidator.IsValidPhoneNumber(text))
            {
                MessageBox.Show("The input you wrote is an incorrect format, try again");
                return;
            }

            List<Employee> employees = Employee.SearchByPhoneNumber(text);

            if (employees.Count == 0)
            {
                MessageBox.Show("That Phone Number is not in our records");
                return;
            }

            clearFields();
            listViewSearch.Items.Clear();

            foreach (Employee emp in employees)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                item.SubItems.Add(emp.FirstName);
                item.SubItems.Add(emp.LastName);
                item.SubItems.Add(emp.Email);
                item.SubItems.Add(emp.PhoneNumber);
                item.SubItems.Add(emp.StatusDesc);
                item.SubItems.Add(emp.JobTitle);

                listViewSearch.Items.Add(item);
            }
        }


        /// <summary>
        /// Handles listing all employees in the list view.
        /// </summary>

        private void buttonListAll_Click(object sender, EventArgs e)
        {
            // Retrieves all employees from the database and displays them in the list view.

            List<Employee> employees = new List<Employee>();

            employees = Employee.GetEmployees();

            listViewAllEmployees.Items.Clear();

            foreach (Employee emp in employees)
            {
                ListViewItem row = new ListViewItem(emp.EmployeeId.ToString());
                row.SubItems.Add(emp.FirstName);
                row.SubItems.Add(emp.LastName);
                row.SubItems.Add(emp.Email);
                row.SubItems.Add(emp.PhoneNumber);
                row.SubItems.Add(emp.StatusDesc);
                row.SubItems.Add(emp.JobTitle);

                listViewAllEmployees.Items.Add(row);
            }

        }



        /// <summary>
        /// Handles adding a new employee.
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Validates the input fields for adding a new employee, adds the employee to the database, and displays a success message.

            string input = textBoxFirstName.Text.Trim();

            if (!MyValidator.IsValidText(input))
            {
                MessageBox.Show("The Firstname you wrote is not correct, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            input = textBoxLastName.Text.Trim();

            if (!MyValidator.IsValidText(input))
            {
                MessageBox.Show("The Lastname you wrote is not correct, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            input = textBoxEmail.Text.Trim();

            if (!MyValidator.IsValidEmail(input))
            {
                MessageBox.Show("The Email you wrote is not correct, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            input = textBoxPhoneNumber.Text.Trim();

            if (!MyValidator.IsValidPhoneNumber(input))
            {
                MessageBox.Show("The Phone number you wrote is not correct, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select a Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (comboBoxJobTitle.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select a Job title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee emp = new Employee();

            emp.FirstName = textBoxFirstName.Text.Trim();
            emp.LastName = textBoxLastName.Text.Trim();
            emp.Email = textBoxEmail.Text.Trim();
            emp.PhoneNumber = textBoxPhoneNumber.Text.Trim();
            emp.StatusId = statusPK(comboBoxStatus.SelectedIndex);
            emp.JobId = jobTitlePK(comboBoxJobTitle.SelectedIndex);

            if (!emp.AddEmployee(emp))
            {
                MessageBox.Show("Error at time to add the Employee");
                return;
            }

            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxPhoneNumber.Clear();
            textBoxPhoneNumber.Clear();
            comboBoxStatus.SelectedIndex = 0;
            comboBoxJobTitle.SelectedIndex = 0;

            textBoxFirstName.Focus();

            MessageBox.Show("The Employee was add successfully");

        }



        /// <summary>
        /// Converts the combobox selected index for status to its corresponding primary key.
        /// </summary>

        private int statusPK(int idx)
        {
            // Returns the primary key based on the selected index for status.

            switch (idx)
            {
                case 0:
                    return 3;
                case 1:
                    return 4;
                case 2:
                    return 5;
                default:
                    return -1;
            }
        }


        /// <summary>
        /// Converts the combobox selected index for job title to its corresponding primary key.
        /// </summary>

        private int jobTitlePK(int idx)
        {
            // Returns the primary key based on the selected index for job title.

            return idx + 1;
        }

        /// <summary>
        /// Handles the search button click event to initiate different search operations based on the selected search criteria.
        /// </summary>
        
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // Initiates search based on the selected search criteria (ID, First Name, Last Name, Email, Phone Number).

            int idx = comboBoxSearchBy.SelectedIndex;

            switch (idx)
            {
                case 0:     //Search By ID
                    SearchByID();
                    break;
                case 1:     //Search By FirstName
                    SearchByFirstName();
                    break;
                case 2:     //Search By LastName
                    SearchByLastName();
                    break;
                case 3:     // Search By Email
                    SearchByEmail();
                    break;
                case 4:     // Search By PhoneNumber
                    SearchByPhoneNumber();
                    break;
            }
        }

        /// <summary>
        /// Handles the combobox selected index changed event to update a label's text based on the selected search criteria.
        /// </summary>

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*  ID
                First Name
                Last Name
                Email
                Phone Number
            */

            // Updates the label's text with a hint or description based on the selected search criteria.

            switch (comboBoxSearchBy.SelectedIndex)
            {
                case 0:
                    label19.Text = "7 digits for ID";
                    break;
                case 1:
                    label19.Text = "Only text";
                    break;
                case 2:
                    label19.Text = "Only text";
                    break;
                case 3:
                    label19.Text = "example@example.com";
                    break;
                case 4:
                    label19.Text = "(777)777-7777";
                    break;

            }

            label19.Show();

            textBoxSearchBy.Clear();
            
        }


        /// <summary>
        /// Handles the button click event to update an employee's details.
        /// </summary>

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Validates and updates an employee's details in the database based on the provided input.

            string text = textBoxSearchEmployeeID.Text;
            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("The Employee ID is empty, please, Search the ID before Update");
                return;
            }

            text = textBoxSearchFirstName.Text.Trim();

            if (!MyValidator.IsValidText(text))
            {
                MessageBox.Show("The Firstname you wrote is an invalid format, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSearchFirstName.Clear();
                textBoxSearchFirstName.Focus();
                return;
            }

            text = textBoxSearchLastName.Text.Trim();

            if(!MyValidator.IsValidText(text))
            {
                MessageBox.Show("The Last name you wrote is an invalid format, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSearchLastName.Clear();
                textBoxSearchLastName.Focus();
                return;
            }

            text = textBoxSearchEmail.Text.Trim();

            if (!MyValidator.IsValidEmail(text))
            {
                MessageBox.Show("The Email you wrote is an invalid format, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSearchEmail.Clear();
                textBoxSearchEmail.Focus();
                return;
            }

            text = textBoxSearchPhoneNumber.Text.Trim();

            if (!MyValidator.IsValidPhoneNumber(text))
            {
                MessageBox.Show("The Phone number you wrote is an invalid format, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSearchPhoneNumber.Clear();
                textBoxSearchPhoneNumber.Focus();
                return;
            }

            Employee newEmp = new Employee();

            newEmp.FirstName = textBoxSearchFirstName.Text.Trim();
            newEmp.LastName = textBoxSearchLastName.Text.Trim();
            newEmp.Email = textBoxSearchEmail.Text.Trim();
            newEmp.PhoneNumber = textBoxSearchPhoneNumber.Text.Trim();

            int idx = comboBoxSearchStatus.SelectedIndex;

            newEmp.StatusId = statusPK(idx);

            idx = comboBoxSearchJobTitle.SelectedIndex;

            newEmp.JobId = jobTitlePK(idx);

            Employee.UpdateEmployee(newEmp);
            

            MessageBox.Show($"The employee {newEmp.FirstName} {newEmp.LastName} was updated succesfully", "Information", MessageBoxButtons.OK);

            clearFields();

        }

        /// <summary>
        /// Handles the button click event to delete an employee.
        /// </summary>

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Validates and confirms deletion of an employee from the database.

            if (textBoxSearchEmployeeID.Text.Length == 0)
            {
                MessageBox.Show("Please, Search by ID the Employee you want to Delete");
                return;
            }

            DialogResult dr = MessageBox.Show($"Do you want to delete the Employee{textBoxSearchFirstName.Text} {textBoxSearchLastName.Text}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                int id = Convert.ToInt32(textBoxSearchEmployeeID.Text);
                try
                {
                    Employee.DeleteEmployee(id);
                    MessageBox.Show("Success Delete", "Information");
                    clearFields();
                    listViewSearch.Items.Clear();
                }
                catch (Exception ep)
                {
                    MessageBox.Show("There were a problem at delete the employee" + ep.ToString());
                    return;
                }

            }


        }

        /// <summary>
        /// Handles the button click event to exit the form.
        /// </summary>

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Prompts the user to confirm closing the form and returns to the previous form upon confirmation.

            DialogResult result = MessageBox.Show("Do you want to close this window?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                prevForm.Show();
                Close();
            }
        }
    }
}
