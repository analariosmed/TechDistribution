using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.BLL;

namespace TechDistribution.DAL
{
    public class PublisherRepository : BaseRepository
    {
        public PublisherRepository(TechDistributionEntities dbContext) : base(dbContext)
        {

        }

        public List<Publisher> GetPublishers() => dbContext.Publishers.ToList();


    }
}
