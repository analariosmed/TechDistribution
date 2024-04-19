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
    public partial class InventoryControllerMainForm : Form
    {
        public InventoryControllerMainForm()
        {
            InitializeComponent();
        }

        private void buttonToBookManagement_Click(object sender, EventArgs e)
        {
            Form BookManagement = new BookForm(this);

            BookManagement.Show();
            Hide();

        }

        private void buttonToAuthorManagement_Click(object sender, EventArgs e)
        {
            Form authorManagement = new AuthorForm(this);

            authorManagement.Show();
            Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("you're login out, are you sure?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Form login = new EmployeeLogin();
                login.Show();
                Close();
            }
        }
    }
}
