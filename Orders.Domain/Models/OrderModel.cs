using System;

namespace Orders.Domain.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public UserModel User { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
    }
}
