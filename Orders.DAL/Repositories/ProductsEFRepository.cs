using Orders.DAL.Models;
using System.Linq;

namespace Orders.DAL.Repositories
{
    public class ProductsEFRepository
    {
        private readonly OrdersDBMigrationContext _ctx;
        public ProductsEFRepository()
        {
            _ctx = new OrdersDBMigrationContext();
        }

        public Product Create(Product model)
        {
            _ctx.Products.Add(model);
            _ctx.SaveChanges();

            return model;
        }

        public void DeleteById(int id)
        {
            var entity = _ctx.Products.FirstOrDefault(x => x.Id == id);
            _ctx.Products.Remove(entity);

            _ctx.SaveChanges();
        }

        public Product Update(Product model)
        {
            var entity = _ctx.Products.FirstOrDefault(x => x.Id == model.Id);
            entity.Name = model.Name;
            entity.Price = model.Price;

            _ctx.SaveChanges();

            return entity;
        }
    }
}
