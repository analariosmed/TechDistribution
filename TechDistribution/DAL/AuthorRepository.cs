using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.BLL;

namespace TechDistribution.DAL
{
    public class AuthorRepository : BaseRepository
    {
        public AuthorRepository(TechDistributionEntities dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Author> GetAuthors() => dbContext.Authors.ToList();

        

    }
}
