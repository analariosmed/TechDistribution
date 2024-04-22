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
    /// Handles database operations for the Author entity.
    /// </summary>
    public class AuthorRepository : BaseRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public AuthorRepository(TechDistributionEntities dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Retrieves all authors from the database.
        /// </summary>
        /// <returns>A list of all authors.</returns>
        public List<Author> GetAuthors() => dbContext.Authors.ToList();

        /// <summary>
        /// Adds a new author to the database.
        /// </summary>
        /// <param name="nAuthor">The new author object to add.</param>
        public void AddAuthor(Author nAuthor)
        {
            var dbContextTransaction = dbContext.Database.BeginTransaction();
            try
            {
                dbContext.Authors.Add(nAuthor);
                dbContext.SaveChanges();
                dbContextTransaction.Commit();
            }
            catch (Exception e)
            {
                MessageBox.Show($"There was a problem adding the author to the database. Error: {e}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbContextTransaction.Rollback();
            }
        }

        /// <summary>
        /// Retrieves an author from the database by their ID.
        /// </summary>
        /// <param name="authorId">The ID of the author to retrieve.</param>
        /// <returns>The author object.</returns>
        public Author GetAuthorById(int authorId) => dbContext.Authors.Where(x => x.AuthorID == authorId).First();

        /// <summary>
        /// Retrieves authors from the database by their name.
        /// </summary>
        /// <param name="name">The first name or last name of the author to search for.</param>
        /// <returns>A list of authors matching the name criteria.</returns>
        public List<Author> GetAuthorsByName(string name) => dbContext.Authors.Where(x => x.FirstName == name || x.LastName == name).ToList();

        /// <summary>
        /// Retrieves authors from the database by their email.
        /// </summary>
        /// <param name="email">The email address of the author to search for.</param>
        /// <returns>A list of authors matching the email criteria.</returns>
        public List<Author> GetAuthorsByEmail(string email) => dbContext.Authors.Where(x => x.Email == email).ToList();

        /// <summary>
        /// Updates an existing author in the database.
        /// </summary>
        /// <param name="edAuthor">The updated author object.</param>
        public void UpdateAuthor(Author edAuthor)
        {
            var dbContextTransacition = dbContext.Database.BeginTransaction();

            // Code for updating an author
        }

        /// <summary>
        /// Checks if an author with the given ID exists in the database.
        /// </summary>
        /// <param name="authorId">The ID of the author to check.</param>
        /// <returns>True if the author exists, otherwise false.</returns>
        public bool IsAnExistingAuthor(int authorId)
        {
            Author fAuthor = new Author();
            fAuthor = GetAuthorById(authorId);

            if (fAuthor == null)
                return false;
            else
                return true;
        }
    }
}
