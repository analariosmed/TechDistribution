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
using TechDistribution.BLL;
using TechDistribution.DAL;
using TechDistribution.VALIDATION;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TechDistribution.GUI
{
    public partial class AuthorForm : Form
    {
        TechDistributionEntities dbContext;
        AuthorController auCtrl;
        public AuthorForm()
        {
            dbContext = new TechDistributionEntities();
            auCtrl = new AuthorController(dbContext);
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string text = textBoxFirstName.Text.Trim();

            if (!MyValidator.IsValidName(text))
            {
                MessageBox.Show("The name is not valid");
                return;
            }
            text = textBoxLastName.Text.Trim();
            if (!MyValidator.IsValidName(text))
            {
                MessageBox.Show("The lastname is not valid");
                return;
            }

            text = textBoxEmail.Text.Trim();

            if (!MyValidator.IsValidEmail(text))
            {
                MessageBox.Show("The email is not valid");
                return;
            }


            Author author = new Author();

            author.FirstName = textBoxFirstName.Text;
            author.LastName = textBoxLastName.Text;
            author.Email = textBoxEmail.Text;

            auCtrl.AddNewAuthor(author);

            MessageBox.Show("Added Succesfully");

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            switch (comboBoxSearchBy.SelectedIndex)
            {
                case 0: // ID
                    SearchById();
                    break;
                case 1: //Name
                    SearchByName();
                    break;
                case 2: //Email
                    SearchByEmail();
                    break;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string text = textBoxIDUpdate.Text;

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("The ID is empty, please, search first");
                return;
            }

            if (!MyValidator.IsValidName(text))
            {
                MessageBox.Show("The name is not valid");
                return;
            }
            text = textBoxLastName.Text.Trim();
            if (!MyValidator.IsValidName(text))
            {
                MessageBox.Show("The lastname is not valid");
                return;
            }

            text = textBoxEmail.Text.Trim();

            if (!MyValidator.IsValidEmail(text))
            {
                MessageBox.Show("The email is not valid");
                return;
            }

            Author updateAuthor = new Author();

            updateAuthor.AuthorID = Convert.ToInt16(textBoxIDUpdate.Text);
            updateAuthor.FirstName = textBoxUpdateFirstName.Text;
            updateAuthor.LastName = textBoxUpdateLastName.Text;
            updateAuthor.Email = textBoxUpdateEmail.Text;

            auCtrl.UpdateTheAuthor(updateAuthor);

            MessageBox.Show($"Updated! {updateAuthor.AuthorID}");

        }

        private void buttonListAllAuthors_Click(object sender, EventArgs e)
        {
            


            dataGridView2.DataSource = null;
            dataGridView2.Refresh();

            dataGridView2.DataSource = auCtrl.GetAllAuthors();
        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSearchBy.SelectedIndex)
            {
                case 0: // ID
                    label9.Text = "ID";
                    break;
                case 1: //Name
                    label9.Text = "Only text";
                    break;
                case 2: //Email
                    label9.Text = "example@example.com";
                    break;
            }
        }

        private void SearchById()
        {
            string text = textBoxSearchBy.Text;
            int id;

            if(!int.TryParse(text, out id))
            {
                MessageBox.Show("The ID is invalid");
                return;
            }

            Author au = new Author();
            au = auCtrl.GetById(id);

            textBoxIDUpdate.Text = au.AuthorID.ToString();
            textBoxUpdateFirstName.Text = au.FirstName;
            textBoxUpdateLastName.Text = au.LastName;
            textBoxUpdateEmail.Text = au.Email;

            List<Author> toShow = new List<Author>
            {
                au
            };

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = toShow;


        }

        private void SearchByName()
        {
            string text = textBoxSearchBy.Text;
            if (!MyValidator.IsValidText(text))
            {
                MessageBox.Show("The Name is not correct");
                return;
            }

            var search = auCtrl.GetByName(text);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = search;


        }
        private void SearchByEmail()
        {
            string text = textBoxSearchBy.Text;
            if (!MyValidator.IsValidEmail(text))
            {
                MessageBox.Show("The Email is not correct");
                return;
            }

            var search = auCtrl.GetByEmail(text);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = search;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new InventoryController();
            form.Show();
        }
    }
}
