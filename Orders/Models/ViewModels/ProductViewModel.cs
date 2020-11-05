using System.Collections.Generic;

namespace Orders.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public ICollection<OrderViewModel> Orders { get; set; }
    }
}
