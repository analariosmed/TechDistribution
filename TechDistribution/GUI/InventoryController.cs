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
    public partial class InventoryController : Form
    {
        public InventoryController()
        {
            InitializeComponent();
        }
        AuthorForm authorForm;
        BookForm bookForm;
        Login loginForm;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new AuthorForm();
            form.Show();
        }

        private void buttonBookManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new BookForm();
            form.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Login();
            form.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
