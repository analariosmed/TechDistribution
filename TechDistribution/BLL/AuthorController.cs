using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.DAL;

namespace TechDistribution.BLL
{
    /// <summary>
    /// Handles business logic operations for the Author entity.
    /// </summary>
    public class AuthorController : AuthorRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorController"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public AuthorController(TechDistributionEntities dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Retrieves all authors from the database.
        /// </summary>
        /// <returns>A list of all authors.</returns>
        public List<Author> GetAllAuthors() => GetAuthors();

        /// <summary>
        /// Adds a new author to the database.
        /// </summary>
        /// <param name="nAuthor">The new author object to add.</param>
        public void AddNewAuthor(Author nAuthor) => AddAuthor(nAuthor);

        /// <summary>
        /// Retrieves an author from the database by their ID.
        /// </summary>
        /// <param name="authorId">The ID of the author to retrieve.</param>
        /// <returns>The author object.</returns>
        public Author GetById(int authorId) => GetAuthorById(authorId);

        /// <summary>
        /// Retrieves authors from the database by their name.
        /// </summary>
        /// <param name="name">The first name or last name of the author to search for.</param>
        /// <returns>A list of authors matching the name criteria.</returns>
        public List<Author> GetByName(string name) => GetAuthorsByName(name);

        /// <summary>
        /// Retrieves authors from the database by their email.
        /// </summary>
        /// <param name="email">The email address of the author to search for.</param>
        /// <returns>A list of authors matching the email criteria.</returns>
        public List<Author> GetByEmail(string email) => GetAuthorsByEmail(email);

        /// <summary>
        /// Updates an existing author in the database.
        /// </summary>
        /// <param name="edAuthor">The updated author object.</param>
        public void UpdateTheAuthor(Author edAuthor) => UpdateAuthor(edAuthor);

        /// <summary>
        /// Checks if an author with the given ID exists in the database.
        /// </summary>
        /// <param name="authorId">The ID of the author to check.</param>
        /// <returns>True if the author exists, otherwise false.</returns>
        public bool IsAnExistingOne(int authorId) => IsAnExistingAuthor(authorId);
    }
}
