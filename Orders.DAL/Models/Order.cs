using System;
using System.Collections.Generic;

namespace Orders.DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
