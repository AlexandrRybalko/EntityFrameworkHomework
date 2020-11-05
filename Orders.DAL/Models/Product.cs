using System.Collections.Generic;

namespace Orders.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
