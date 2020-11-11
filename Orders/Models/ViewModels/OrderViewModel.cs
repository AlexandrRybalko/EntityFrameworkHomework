using System;
using System.Collections.Generic;

namespace Orders.Models.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public UserViewModel User { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
