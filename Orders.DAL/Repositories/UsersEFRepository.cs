using Orders.DAL.Models;
using System.Linq;

namespace Orders.DAL.Repositories
{
    public class UsersEFRepository
    {
        private readonly OrdersDBContext _ctx;
        
        public UsersEFRepository()
        {
            _ctx = new OrdersDBContext();
        }

        public User Create(User model)
        {
            _ctx.Users.Add(model);
            _ctx.SaveChanges();

            return model;
        }

        public void DeleteById(int id)
        {
            var entity = _ctx.Users.FirstOrDefault(x => x.Id == id);
            _ctx.Users.Remove(entity);

            _ctx.SaveChanges();
        }

        public User Update(User model)
        {
            var entity = _ctx.Users.FirstOrDefault(x => x.Id == model.Id);

            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.PhoneNumber = model.PhoneNumber;

            _ctx.SaveChanges();

            return entity;
        }
    }
}
