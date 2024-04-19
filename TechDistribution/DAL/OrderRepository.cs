using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.BLL;

namespace TechDistribution.DAL
{
    public class OrderRepository : BaseRepository
    {
        public OrderRepository(TechDistributionEntities dbContext) : base(dbContext)
        {
        }
       
        public void AddOrder(Order nOrder)
        {
            dbContext.Orders.Add(nOrder);


            dbContext.SaveChanges();
        }

        public List<Order> GetOrders()
        {
            return dbContext.Orders.ToList();
        }

        public void UpdateOrder(Order edOrder)
        {
            Order order = dbContext.Orders.Where(o => o.OrderID == edOrder.OrderID).FirstOrDefault();
            order.OrderDate = edOrder.OrderDate;
            order.OrderType = edOrder.OrderType;
            order.StatusId = edOrder.StatusId;
            order.PaymentMethod = edOrder.PaymentMethod;
            order.TotalPayment = edOrder.TotalPayment;
            order.Email = edOrder.Email;
            order.PhoneNumber = edOrder.PhoneNumber;
            order.Fax = edOrder.Fax;


            dbContext.SaveChanges();
        }

        public Order GetOrderByID(int orderId)
        {
            return dbContext.Orders.Where(o => o.OrderID == orderId).FirstOrDefault();
        }

        public List<Order> GetOrdersByDate(DateTime date)
        {
            return dbContext.Orders.Where(o => o.OrderDate == date).ToList();
        }

        public List<Order> GetOrdersByStatus(int statusId)
        {
            return dbContext.Orders.Where(o => o.StatusId == statusId).ToList();
        } 
        public bool isAnExistingOrder(int orderId)
        {
            return dbContext.Orders.Any(o => o.OrderID == orderId);
        }
        public void DeleteOrder(int orderId)
        {
            Order order = dbContext.Orders.Where(o => o.OrderID == orderId).FirstOrDefault();
            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();
        }





        
    }
}
