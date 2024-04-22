using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.DAL;

namespace TechDistribution.BLL
{
    public class AuthorController
    {
        TechDistributionEntities dbContext;
        AuthorRepository authorRep;
        public AuthorController()
        {
            dbContext = new TechDistributionEntities();
            authorRep = new AuthorRepository(dbContext);
        }

        public List<Author> GetAuthors() => authorRep.GetAuthors();

        public void AddAuthor(Author nAuthor) => authorRep.AddAuthor(nAuthor);

        public Author GetAuthorById(int authorId) => authorRep.GetAuthorById(authorId);

        public List<Author> GetAuthorByName(string name) => authorRep.GetAuthorsByName(name);

        public List<Author> GetAuthorByEmail(string email) => authorRep.GetAuthorsByEmail(email);

        public void UpdateAuthor(Author edAuthor) => authorRep.UpdateAuthor(edAuthor);

        public bool IsAnExistingAuthor(int authorId) => authorRep.IsAnExistingAuthor(authorId);


    }
}
