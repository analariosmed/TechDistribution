using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.VALIDATION;

namespace TechDistribution.GUI
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string toValidate = textBoxIsbn.Text;
            if (!VALIDATION.Validator.IsValidISBN(toValidate))
            {
                MessageBox.Show("Invalid ISBN");
                return;
            }
            toValidate = textBoxTitle.Text;
            if (!VALIDATION.Validator.IsValidText(toValidate))
            {
                MessageBox.Show("Invalid Title");
                return;
            }

            toValidate = textBoxUnitPrice.Text;
            if (!VALIDATION.Validator.IsValidPrice(toValidate))
            {
                MessageBox.Show("Invalid Title");
                return;
            }

            toValidate = textBoxTitle.Text;
            if (!VALIDATION.Validator.IsValidText(toValidate))
            {
                MessageBox.Show("Invalid Title");
                return;
            }
            toValidate = textBoxTitle.Text;
            if (!VALIDATION.Validator.IsValidText(toValidate))
            {
                MessageBox.Show("Invalid Title");
                return;
            }



        }
    }
}
