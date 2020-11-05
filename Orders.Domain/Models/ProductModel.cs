using System.Collections.Generic;

namespace Orders.Domain.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public ICollection<OrderModel> Orders { get; set; }
    }
}
