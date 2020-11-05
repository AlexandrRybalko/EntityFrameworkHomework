using System;

namespace Orders.Models.PostModels
{
    public class OrderPostModel
    {
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public UserPostModel User { get; set; }
        public int ProductId { get; set; }
        public ProductPostModel Product { get; set; }
    }
}
