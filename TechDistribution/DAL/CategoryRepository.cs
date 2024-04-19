using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.BLL;

namespace TechDistribution.DAL
{
    public class CategoryRepository : BaseRepository
    {
        public CategoryRepository(TechDistributionEntities dbContext) : base(dbContext)
        {
        }

        public List<Category> GetCategories() => dbContext.Categories.ToList();
    }
}
