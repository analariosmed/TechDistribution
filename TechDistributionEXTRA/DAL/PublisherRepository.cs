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

        public static List<Publisher> GetPublishers()
        {
            TechDistributionEntities temp = new TechDistributionEntities();

            return temp.Publishers.ToList();
        }

        public static int GetPublisherIdByName(string name)
        {
            TechDistributionEntities temp = new TechDistributionEntities();

            return temp.Publishers.Where(x => x.PublisherName == name).First().PublisherID;
        }

    }
}
