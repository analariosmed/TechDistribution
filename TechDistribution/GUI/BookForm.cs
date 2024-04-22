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

namespace TechDistribution.GUI
{
    public partial class BookForm : Form
    {
        TechDistributionEntities tech;
        BookController bookController;
        AuthorController authorController;
        Form prevForm;

        /// <summary>
        /// Initializes the BookForm with necessary components and controllers.
        /// </summary>

        public BookForm(Form prevForm)
        {
            // Initialization code for form components and controllers.

            this.prevForm = prevForm;
            tech = new TechDistributionEntities();
            bookController = new BookController(tech);
            authorController = new AuthorController(tech);
            InitializeComponent();

            var categories = CategoryRepository.GetCategories();

            foreach (var catg in categories)
            {
                comboBoxCategory.Items.Add(catg.CategoryName);
                comboBoxCategoryUpdate.Items.Add(catg.CategoryName);
            }

            var publishers = PublisherRepository.GetPublishers();

            foreach (var publ in publishers)
            {
                comboBoxPublisher.Items.Add(publ.PublisherName);
                comboBoxPublisherUpdate.Items.Add(publ.PublisherName);
            }

            var books = bookController.GetBooks();

            foreach (var book in books)
            {
                string text = $"{book.ISBN},{book.Title}";
                comboBoxBooks.Items.Add(text);
            }

            var authors = authorController.GetAuthors();
            foreach (var author in authors)
            {
                string text = $"{author.AuthorID}, {author.FirstName} {author.LastName}";
                comboBoxAuthors.Items.Add(text);
            }

            //comboBoxCategory
            //comboBoxPublisher
            //comboBox1
            //comboBoxAuthors
            //comboBoxBooks

            comboBoxCategory.SelectedIndex = 0;
            comboBoxPublisher.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBoxAuthors.SelectedIndex = 0;
            comboBoxBooks.SelectedIndex = 0;


        }

        /// <summary>
        /// Handles the button click event to add a new book, performing validation checks on input fields.
        /// </summary>

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            // Validates ISBN, title, price, year, and quantity on hand before adding a new book.

            string toValidate = textBoxIsbn.Text;

            
            if (MyValidator.IsValidISBN(toValidate))
            {
                MessageBox.Show("Invalid ISBN");
                return;
            }

            if (BookRepository.IsAnExistingBook(toValidate))
            {
                MessageBox.Show("ISBN in usage");
                return;
            }

            toValidate = textBoxTitle.Text.Trim();
            if (MyValidator.IsValidText(toValidate))
            {
                MessageBox.Show("Invalid Title");
                return;
            }

            toValidate = textBoxUnitPrice.Text.Trim();
            if (MyValidator.IsValidPrice(toValidate))
            {
                MessageBox.Show("Invalid Price");
                return;
            }
            toValidate = textBoxYear.Text.Trim();
            if (MyValidator.IsValidText(toValidate))
            {
                MessageBox.Show("Invalid Year");
                return;
            }
            toValidate = textBoxQOH.Text.Trim();
            int qoh;
            if (!int.TryParse(toValidate, out qoh))
            {
                MessageBox.Show("Invalid Quantity on Hand");
                return;
            }

            Book bookToAdd = new Book();

       

            bookToAdd.ISBN = textBoxIsbn.Text.Trim();
            bookToAdd.Title = textBoxTitle.Text.Trim();
            bookToAdd.UnitPrice = Convert.ToDecimal(textBoxYear.Text.Trim());
            bookToAdd.YearPublished = Convert.ToInt32(textBoxYear.Text.Trim());
            bookToAdd.QOH = Convert.ToInt32(textBoxQOH.Text.Trim());
            bookToAdd.CategoryID = CategoryRepository.GetIdByCategoryName(comboBoxCategory.Text.Trim());
            bookToAdd.PublisherID = PublisherRepository.GetPublisherIdByName(comboBoxPublisher.Text.Trim());

            BookController controller = new BookController(tech);

            controller.AddBook(bookToAdd);

            MessageBox.Show("The book was added Succesfully");

        }



        /// <summary>
        /// Handles the button click event to list all books in the DataGridView.
        /// </summary>

        private void buttonListAllBooks_Click(object sender, EventArgs e)
        {
            // Clears and refreshes the DataGridView, then retrieves all books from the database and binds them to the DataGridView for display.

            dataGridView2.DataSource = null;
            dataGridView2.Refresh();

            TechDistributionEntities dbContext = new TechDistributionEntities();

            BookRepository books = new BookRepository(dbContext);

            dataGridView2.DataSource = books.GetBooks();
        }



        /// <summary>
        /// Handles the ComboBox selected index changed event to update a label's text based on the selected index.
        /// </summary>

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Updates the label's text with a hint or description based on the selected index of the ComboBox.

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label9.Text = "hint: 978-0-306-40615-7";
                    break;
                case 1:
                    label9.Text = "name of the book";
                    break;
            }
        }




        /// <summary>
        /// Handles the button click event to search for books based on ISBN or title.
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Checks the selected search criteria (ISBN or title) and performs the corresponding search operation.
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    SearchByISBN();
                    break;
                case 1:
                    SearchByName();
                    break;
            }
        }



        /// <summary>
        /// Searches for a book by ISBN and displays its details.
        /// </summary>

        private void SearchByISBN()
        {
            // Validates the ISBN input and retrieves the book details if the ISBN is valid.

            BookController ctrl = new BookController(tech);

            string text = textBoxSearchBy.Text;
            if (MyValidator.IsValidISBN(text))
            {
                MessageBox.Show("Invalid ISBN");
                return;
            }

            if (!BookRepository.IsAnExistingBook(text))
            {
                MessageBox.Show("ISBN doesn't not exist");
                return;
            }

            Book book = new Book();

            book = bookController.GetByISBN(text);


            textBoxIsbnUpdate.Text = book.ISBN;
            textBoxTitleUpdate.Text = book.Title;
            textBoxUnitPriceUpdate.Text = book.UnitPrice.ToString();
            YearPublishedUpdate.Text = book.YearPublished.ToString();
            textBoxQohUpdate.Text = book.QOH.ToString();

            comboBoxCategoryUpdate.SelectedItem = book.Category.CategoryName;
            comboBoxPublisherUpdate.SelectedItem = book.Publisher.PublisherName;

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            List<Book> toGridView = new List<Book>();
            toGridView.Add(book);

            dataGridView1.DataSource = toGridView;


        }



        /// <summary>
        /// Searches for books by title and displays the search results.
        /// </summary>

        private void SearchByName()
        {
            // Validates the title input and displays books matching the given title.


            string text = textBoxSearchBy.Text.Trim();
            if (!MyValidator.IsValidText(text))
            {
                MessageBox.Show("Invalid Title");
                return;
            }

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = bookController.GetBooksByTitle(text);

        }



        /// <summary>
        /// Handles the button click event to delete a book by ISBN.
        /// </summary>

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Validates the ISBN input, checks if the book exists, and deletes it if found.

            string text = textBoxIsbnUpdate.Text;

            TechDistributionEntities temp = new TechDistributionEntities();
            BookRepository rep = new BookRepository(temp);

            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("The ISBN is empty to delete, Search a book first.");
                return;
            }

            if (MyValidator.IsValidISBN(text))
            {
                MessageBox.Show("Invalid ISBN");
                return;
            }

            if (!BookRepository.IsAnExistingBook(text))
            {
                MessageBox.Show("ISBN doesn't not exist");
                return;
            }

            rep.DeleteBook(text);

            MessageBox.Show($"Book with {text} was Delete sucessfully");

        }

        /// <summary>
        /// Handles the button click event to delete an author assignment from a book.
        /// </summary>
        private void buttonAssignDelete_Click(object sender, EventArgs e)
        {
            // Deletes an author assignment from a book based on the selected row in the authors list.

            int idx = 0;

            try
            {
                idx = dataGridView3.CurrentCell.RowIndex;
            }
            catch
            {
                MessageBox.Show("There's not books in the list");
                return;
            }
            

            if(dataGridView3.DataSource != null)
            {
                MessageBox.Show("There isn't book to delete");
            }

            if(idx == -1)
            {
                MessageBox.Show("Please, select a row to delete please");
                return;
            }
            

            string bookText = comboBoxBooks.Text;
            var array = bookText.Split(',');

            string isbn = array[0];

            Book bookToUpdate = bookController.GetBookByISBN(isbn);

            List<Author> authorsBook = bookController.GetBookByISBN(isbn).Authors.ToList();

            Author AuthorToRemove = authorsBook[idx];

            authorsBook.Remove(AuthorToRemove);

            bookToUpdate.Authors.Clear();

            bookToUpdate.Authors = authorsBook;

            bookController.UpdateBook(bookToUpdate);

            MessageBox.Show("The Author was deleted Succesfully");

            if (dataGridView3.DataSource != null)
            {
                dataGridView3.DataSource = null;
                dataGridView3.Refresh();
            }

            dataGridView3.DataSource = bookToUpdate.Authors.ToList();
        }



        /// <summary>
        /// Handles the button click event to assign an author to a book.
        /// </summary>


        private void buttonAssignAdd_Click(object sender, EventArgs e)
        {
            // Adds an author to a book and updates the book's author list.

            string author = comboBoxAuthors.Text;
            var array = author.Split(',');

            int id = Convert.ToInt32(array[0]);

            Author nAuthor = authorController.GetAuthorById(id);

            string cbBook= comboBoxBooks.Text;
            var bookArray = cbBook.Split(',');

            string isbn = bookArray[0];

            Book book = bookController.GetBookByISBN(isbn);

            var authorsBook = book.Authors.ToList();

            if (authorsBook.Contains(nAuthor))
            {
                MessageBox.Show("The author is already assign in this book");
                dataGridView3.DataSource = null;
                dataGridView3.Refresh();
                return;

            }

            authorsBook.Add(nAuthor);

            book.Authors.Clear();
            book.Authors = authorsBook;

            bookController.UpdateBook(book);

            MessageBox.Show("The Author was added to the book succesfully!");
            
            if(dataGridView3.DataSource != null)
            {
                dataGridView3.DataSource = null;
                dataGridView3.Refresh();
            }

            dataGridView3.DataSource = book.Authors.ToList();

        }

       

        /// <summary>
        /// Handles the button click event to show authors assigned to a specific book.
        /// </summary>

        private void buttonShowAuthors_Click(object sender, EventArgs e)
        {
            // Retrieves and displays authors assigned to a specific book based on ISBN.

            string bookText = comboBoxBooks.Text;
            var array = bookText.Split(',');

            string isbn = array[0];

            var authorsBook = bookController.GetBookByISBN(isbn).Authors.ToList();

            dataGridView3.DataSource = null;
            dataGridView3.Refresh();

            dataGridView3.DataSource = authorsBook;
        }


        /// <summary>
        /// Handles the button click event to exit the BookForm, showing a confirmation dialog.
        /// </summary>

        private void buttonExit_Click(object sender, EventArgs e)
        {

            // Displays a confirmation dialog before closing the BookForm and returning to the previous form.

            DialogResult result = MessageBox.Show("Do you want to close this window?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



            if (result == DialogResult.Yes)
            {
                prevForm.Show();
                Close();
            }
        }
    }
}
