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

    public class BookRepository : BaseRepository
    {
        public BookRepository(TechDistributionEntities dbContext) : base(dbContext)
        {
        }

        public void AddBook(Book book)
        {
            var dbContextTransaction = dbContext.Database.BeginTransaction();

            try
            {

                dbContext.Books.Add(book);
                dbContext.SaveChanges();
                dbContextTransaction.Commit();
            }
            catch(Exception e)
            {
                MessageBox.Show($"There were a problem at time to add the Book to the Database \n Error: {e}", "Dabatase Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbContextTransaction.Rollback();
                throw;
            }
            
        }

        public  List<Book> GetBooks() => dbContext.Books.ToList();

        public void UpdateBook(Book edBook)
        {

            var dbContextTransaction = dbContext.Database.BeginTransaction();

            try
            {
                Book toEdit = GetBookByISBN(edBook.ISBN);

                toEdit.Title = edBook.Title;
                toEdit.QOH = edBook.QOH;
                toEdit.UnitPrice = edBook.UnitPrice;
                toEdit.YearPublished = edBook.YearPublished;
                toEdit.Publisher = edBook.Publisher;
                toEdit.Category = edBook.Category;
                //toEdit.Authors = edBook.Authors; 

                List<Author> listAuthors = edBook.Authors.ToList();

                toEdit.Authors.Clear();

                foreach (Author nAuthor in listAuthors)
                {
                    toEdit.Authors.Add(nAuthor); // This line update the list of author in given book
                }

                dbContext.SaveChanges();
                dbContextTransaction.Commit();

                //MessageBox.Show($"The book {edBook.Title} was update Succesfully", "Succesufully Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show($"There were a problem at time to update the Book into the Database \n Error: {e}", "Dabatase Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbContextTransaction.Rollback();
            }

        }

        public Book GetBookByISBN(string isbn) => dbContext.Books.Where(x => x.ISBN == isbn).First();

        public List<Book> GetBooksByTitle(string name) => dbContext.Books.Where(x => x.Title.Contains(name)).ToList();
        

        public static bool IsAnExistingBook(string isbn)
        {

            TechDistributionEntities temp = new TechDistributionEntities();

            Book fBook = new Book();

            fBook = temp.Books.Find(isbn);

            if (fBook == null)
                return false;
            else
                return true;
        }

        public void DeleteBook(string isbn)
        {
            Book bookToDelete = GetBookByISBN(isbn);

            dbContext.Books.Remove(bookToDelete);
            dbContext.SaveChanges();
        }

    }
}
