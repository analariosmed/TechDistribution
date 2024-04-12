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
    public class AuthorRepository : BaseRepository
    {
        public AuthorRepository(TechDistributionEntities dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Author> GetAuthors() => dbContext.Authors.ToList();

        public void AddAuthor(Author nAuthor)
        {
            var dbContextTransaction = dbContext.Database.BeginTransaction();
            try
            {
                dbContext.Authors.Add(nAuthor);
                dbContext.SaveChanges();
                dbContextTransaction.Commit();
            }
            catch(Exception e)
            {
                MessageBox.Show($"There were a problem at time to add the Author to the Database \n Error: {e}", "Dabatase Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbContextTransaction.Rollback();
            }
            
        }

        public Author GetAuthorById(int authorId) => dbContext.Authors.Where(x => x.AuthorID == authorId).First();

        public List<Author> GetAuthorsByName(string name) => dbContext.Authors.Where(x => x.FirstName == name || x.LastName == name).ToList();

        public List<Author> GetAuthorsByEmail(string email) => dbContext.Authors.Where(x => x.Email == email).ToList();        

        public void UpdateAuthor(Author edAuthor)
        {
            var dbContextTransacition = dbContext.Database.BeginTransaction();

            /*
            try
            {
                Author toEdit = GetAuthorById(edAuthor.AuthorID);

                toEdit.FirstName = edAuthor.FirstName;
                toEdit.LastName = edAuthor.LastName;
                toEdit.Email = edAuthor.Email;
            }


            */
        }


    }
}
