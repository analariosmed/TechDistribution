using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.BLL;

namespace TechDistribution.DAL
{
    public class BaseRepository
    {
        public TechDistributionEntities dbContext;

        public BaseRepository(TechDistributionEntities dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
