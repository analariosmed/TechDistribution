using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.DAL;

namespace TechDistribution.BLL
{
    /// <summary>
    /// Handles business logic operations for the Book entity.
    /// </summary>
    public class BookController : BookRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookController"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public BookController(TechDistributionEntities dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Adds a new book to the database.
        /// </summary>
        /// <param name="nBook">The new book object to add.</param>
        public void AddNewBook(Book nBook) => AddBook(nBook);

        /// <summary>
        /// Retrieves all books from the database.
        /// </summary>
        /// <returns>A list of all books.</returns>
        public List<Book> GetAllBooks() => GetBooks();

        /// <summary>
        /// Updates an existing book in the database.
        /// </summary>
        /// <param name="edBook">The updated book object.</param>
        public void Update(Book edBook) => UpdateBook(edBook);

        /// <summary>
        /// Retrieves a book from the database by its ISBN.
        /// </summary>
        /// <param name="isbn">The ISBN of the book to retrieve.</param>
        /// <returns>The book object.</returns>
        public Book GetByISBN(string isbn) => GetBookByISBN(isbn);

        /// <summary>
        /// Retrieves books from the database by their title.
        /// </summary>
        /// <param name="name">The title or part of the title to search for.</param>
        /// <returns>A list of books matching the title criteria.</returns>
        public List<Book> GetByTitle(string name) => GetBooksByTitle(name);

        /// <summary>
        /// Removes a book from the database by its ISBN.
        /// </summary>
        /// <param name="isbn">The ISBN of the book to remove.</param>
        public void RemoveBook(string isbn)
        {
            DeleteBook(isbn);
        }
    }
}
