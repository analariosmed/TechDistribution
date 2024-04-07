using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.BLL;


namespace TechDistribution.DAL
{

    public class BookRepository : BaseRepository
    {
        public BookRepository(TechDistributionEntities dbContext) : base(dbContext)
        {
        }

        public void addBook(Book book)
        {
            try
            {
                dbContext.Books.Add(book);
                dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
            
        }
    }
}
