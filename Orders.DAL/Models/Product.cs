using System.Collections.Generic;

namespace Orders.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
