using System;
using System.Collections.Generic;

namespace Orders.Models.PostModels
{
    public class OrderPostModel
    {
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public UserPostModel User { get; set; }

        public IEnumerable<ProductPostModel> Products { get; set; }
    }
}
