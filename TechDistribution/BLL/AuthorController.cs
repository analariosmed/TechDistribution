using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.DAL;

namespace TechDistribution.BLL
{
    public class AuthorController : AuthorRepository
    {
        public AuthorController(TechDistributionEntities dbContext) : base(dbContext)
        {
            
        }

        public List<Author> GetAllAuthors() => GetAuthors();

        public void AddNewAuthor(Author nAuthor) => AddAuthor(nAuthor);

        public Author GetById(int authorId) => GetAuthorById(authorId);

        public List<Author> GetByName(string name) => GetAuthorsByName(name);

        public List<Author> GetByEmail(string email) => GetAuthorsByEmail(email);

        public void UpdateTheAuthor(Author edAuthor) => UpdateAuthor(edAuthor);

        public bool IsAnExistingOne(int authorId) => IsAnExistingAuthor(authorId);


    }
}
