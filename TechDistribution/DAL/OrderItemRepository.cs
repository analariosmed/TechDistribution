using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.BLL;

namespace TechDistribution.DAL
{
    public class OrderItemRepository
    {
        TechDistributionEntities dbContext;
        public OrderItemRepository(TechDistributionEntities db)
        {
            dbContext = db;
        }

        public void AddOrderItem(OrderItem nOrderItem)
        {
            dbContext.OrderItems.Add(nOrderItem);
            dbContext.SaveChanges();
        }

        public List<OrderItem> GetOrderItems()
        {
            return dbContext.OrderItems.ToList();
        }

        public void UpdateOrderItem(OrderItem edOrderItem)
        {
            OrderItem oldOrderItem = dbContext.OrderItems.Where(oi => oi.OrderID == edOrderItem.OrderID).FirstOrDefault();
            oldOrderItem.Quantity = edOrderItem.Quantity;
            oldOrderItem.ISBN = edOrderItem.ISBN;
   //         oldOrderItem.OrderID = edOrderItem.OrderID;
            dbContext.SaveChanges();
        }

        public void DeleteOrderItem(int orderItemId)
        {
            OrderItem orderItem = dbContext.OrderItems.Where(oi => oi.OrderID == orderItemId).FirstOrDefault();
            dbContext.OrderItems.Remove(orderItem);
            dbContext.SaveChanges();
        }
    }
}
