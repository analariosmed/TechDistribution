using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.BLL;
using TechDistribution.DAL;

namespace TechDistribution.BLL
{
    public class OrderItemController
    {
        TechDistributionEntities dbContext = new TechDistributionEntities();
        OrderItemRepository orderItemRep;
        public OrderItemController()
        {
            orderItemRep = new OrderItemRepository(dbContext);
        }

        public void AddOrderItem(OrderItem nOrderItem) => orderItemRep.AddOrderItem(nOrderItem);

        public List<OrderItem> GetOrderItems() => orderItemRep.GetOrderItems();

        public void UpdateOrderItem(OrderItem edOrderItem) => orderItemRep.UpdateOrderItem(edOrderItem);

        public void DeleteOrderItem(int orderItemId) => orderItemRep.DeleteOrderItem(orderItemId);

    }
}
