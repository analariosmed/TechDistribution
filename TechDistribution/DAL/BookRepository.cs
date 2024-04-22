using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.BLL;

namespace TechDistribution.DAL
{
    /// <summary>
    /// Handles database operations for the Book entity.
    /// </summary>
    public class BookRepository : BaseRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public BookRepository(TechDistributionEntities dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Adds a new book to the database.
        /// </summary>
        /// <param name="book">The book object to add.</param>
        public void AddBook(Book book)
        {
            var dbContextTransaction = dbContext.Database.BeginTransaction();

            try
            {
                dbContext.Books.Add(book);
                dbContext.SaveChanges();
                dbContextTransaction.Commit();
            }
            catch (Exception e)
            {
                MessageBox.Show($"There was a problem adding the book to the database. Error: {e}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbContextTransaction.Rollback();
                throw;
            }
        }

        /// <summary>
        /// Retrieves all books from the database.
        /// </summary>
        /// <returns>A list of books.</returns>
        public List<Book> GetBooks() => dbContext.Books.ToList();

        /// <summary>
        /// Updates an existing book in the database.
        /// </summary>
        /// <param name="edBook">The updated book object.</param>
        public void UpdateBook(Book edBook)
        {
            // Code for updating a book
        }

        /// <summary>
        /// Retrieves a book from the database by its ISBN.
        /// </summary>
        /// <param name="isbn">The ISBN of the book to retrieve.</param>
        /// <returns>The book object.</returns>
        public Book GetBookByISBN(string isbn) => dbContext.Books.Where(x => x.ISBN == isbn).First();

        /// <summary>
        /// Retrieves books from the database by their title.
        /// </summary>
        /// <param name="name">The title or part of the title to search for.</param>
        /// <returns>A list of books matching the title criteria.</returns>
        public List<Book> GetBooksByTitle(string name) => dbContext.Books.Where(x => x.Title.Contains(name)).ToList();

        /// <summary>
        /// Checks if a book with the given ISBN exists in the database.
        /// </summary>
        /// <param name="isbn">The ISBN to check.</param>
        /// <returns>True if the book exists, otherwise false.</returns>
        public static bool IsAnExistingBook(string isbn)
        {
            TechDistributionEntities temp = new TechDistributionEntities();
            Book fBook = temp.Books.Find(isbn);

            if (fBook == null)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Deletes a book from the database by its ISBN.
        /// </summary>
        /// <param name="isbn">The ISBN of the book to delete.</param>
        public void DeleteBook(string isbn)
        {
            Book bookToDelete = GetBookByISBN(isbn);
            dbContext.Books.Remove(bookToDelete);
            dbContext.SaveChanges();
        }
    }
}
