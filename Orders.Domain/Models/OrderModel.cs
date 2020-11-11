using System;
using System.Collections.Generic;

namespace Orders.Domain.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public UserModel User { get; set; }

        public ICollection<ProductModel> Product { get; set; }
    }
}
