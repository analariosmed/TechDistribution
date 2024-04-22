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

        public static List<Category> GetCategories()
        {
            TechDistributionEntities temp = new TechDistributionEntities();

            return temp.Categories.ToList();
        }

        public static int GetIdByCategoryName(string name)
        {
            TechDistributionEntities temp = new TechDistributionEntities();

            var catg = temp.Categories.Where(x => x.CategoryName == name).First();

            return catg.CategoryID;
        }
    }
}
