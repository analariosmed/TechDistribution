using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.DAL;

namespace TechDistribution.BLL
{
    public class CustomerController
    {
        public static List<Customer> GetCustomers()
        {
            return CustomerDB.GetAllRecords();
        }
    }
}
