using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.DAL;

namespace TechDistribution.BLL
{
    public class BookController
    {
        TechDistributionEntities dbContext = new TechDistributionEntities();
        BookRepository bookRep;
        public BookController()
        {
             bookRep = new BookRepository(dbContext);
        }

        public void AddBook(Book nBook) => bookRep.AddBook(nBook);

        public List<Book> GetBooks() => bookRep.GetBooks();

        public void UpdateBook(Book edBook) => bookRep.UpdateBook(edBook);

        public Book GetBookByISBN(string isbn) => bookRep.GetBookByISBN(isbn);

        public List<Book> GetBooksByTitle(string name) => bookRep.GetBooksByTitle(name);

        public void DeleteBook(string isbn)
        {
            bookRep.DeleteBook(isbn);
        }
    }
}
