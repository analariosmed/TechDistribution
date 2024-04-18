using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.DAL;

namespace TechDistribution.BLL
{
    public class OrderController
    {
        TechDistributionEntities dbContext = new TechDistributionEntities();
        OrderRepository orderRep;
        public OrderController()
        {
            orderRep = new OrderRepository(dbContext);
        }

        public void AddOrder(Order nOrder) => orderRep.AddOrder(nOrder);

        public List<Order> GetOrders() => orderRep.GetOrders();

        public void UpdateOrder(Order edOrder) => orderRep.UpdateOrder(edOrder);

        public Order GetOrderByID(int orderId) => orderRep.GetOrderByID(orderId);

       // public List<Order> GetOrdersByDate(DateTime date) => orderRep.GetOrdersByDate(date);

       // public List<Order> GetOrdersByStatus(int statusId) => orderRep.GetOrdersByStatus(statusId);

        public bool isAnExistingOrder(int orderId) => orderRep.isAnExistingOrder(orderId);

        public void DeleteOrder(int orderId) => orderRep.DeleteOrder(orderId);


    }
}
