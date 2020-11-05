using System;

namespace Orders.Models.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public UserViewModel User { get; set; }
        public int ProductId { get; set; }
        public ProductViewModel Product { get; set; }
    }
}
