using Orders.DAL.Models;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Orders.DAL.Repositories
{
    public class OrdersEFRepository
    {
        private readonly OrdersDBContext _ctx;

        public OrdersEFRepository()
        {
            _ctx = new OrdersDBContext();
        }

        public Order Create(Order model)
        {
            _ctx.Orders.Add(model);
            _ctx.SaveChanges();

            return model;
        }

        public void DeleteById(int id)
        {
            var entity = _ctx.Orders.FirstOrDefault(x => x.Id == id);
            _ctx.Orders.Remove(entity);

            _ctx.SaveChanges();
        }

        public Order Update(Order model)
        {
            var order = _ctx.Orders.FirstOrDefault(x => x.Id == model.Id);
            order.Date = model.Date;

            _ctx.SaveChanges();

            return order;
        }

    }
}
