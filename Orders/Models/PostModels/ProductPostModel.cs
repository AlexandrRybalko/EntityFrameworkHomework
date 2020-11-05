using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Models.PostModels
{
    public class ProductPostModel
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public ICollection<OrderPostModel> Orders { get; set; }
    }
}
