using System.Collections.Generic;

namespace Orders.Models.PostModels
{
    public class ProductPostModel
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public ICollection<OrderPostModel> Orders { get; set; }
    }
}
