using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.BLL;

namespace TechDistribution.DAL
{
    public class StatusRepository : BaseRepository
    {
        public StatusRepository(TechDistributionEntities dbContext) : base(dbContext)
        {
        }

        public Status GetStatusById(int id) => dbContext.Status.Where(x => x.StatusId == id).First();

        public Status GetStatusByDesc(string desc) => dbContext.Status.Where(x => x.StatusDesc == desc).First();

    }
}
