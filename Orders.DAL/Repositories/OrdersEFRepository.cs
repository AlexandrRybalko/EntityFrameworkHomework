using Orders.DAL.Models;
using System.Linq;

namespace Orders.DAL.Repositories
{
    public class OrdersEFRepository
    {
        private readonly OrdersDBContext _ctx;

        public OrdersEFRepository()
        {
            _ctx = new OrdersDBContext();
        }

        public Product CreateProduct(Product model)
        {
            _ctx.Products.Add(model);
            _ctx.SaveChanges();

            return model;
        }

        public void DeleteProductById(int id)
        {
            var entity = _ctx.Products.FirstOrDefault(x => x.Id == id);
            _ctx.Products.Remove(entity);

            _ctx.SaveChanges();
        }

        public User CreateUser(User model)
        {
            _ctx.Users.Add(model);
            _ctx.SaveChanges();

            return model;
        }

        public void DeleteUserById(int id)
        {
            var entity = _ctx.Users.FirstOrDefault(x => x.Id == id);
            _ctx.Users.Remove(entity);

            _ctx.SaveChanges();
        }

        public Order CreateOrder(Order model)
        {
            _ctx.Orders.Add(model);
            _ctx.SaveChanges();

            return model;
        }

        public void DeleteOrderById(int id)
        {
            var entity = _ctx.Orders.FirstOrDefault(x => x.Id == id);
            _ctx.Orders.Remove(entity);

            _ctx.SaveChanges();
        }
    }
}
