using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.DAL;

namespace TechDistribution.BLL
{
    public class BookController : BookRepository
    {
        
        public BookController(TechDistributionEntities dbContext) : base(dbContext)
        {
            
        }

        public void AddNewBook(Book nBook) => AddBook(nBook);

        public List<Book> GetAllBooks() => GetBooks();

        public void Update(Book edBook) => UpdateBook(edBook);

        public Book GetByISBN(string isbn) => GetBookByISBN(isbn);

        public List<Book> GetByTitle(string name) => GetBooksByTitle(name);

        public void RemoveBook(string isbn)
        {
            DeleteBook(isbn);
        }
    }
}
