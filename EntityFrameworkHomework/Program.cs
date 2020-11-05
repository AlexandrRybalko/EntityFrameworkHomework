using Orders.Controllers;
using Orders.Models.PostModels;
using System;

namespace EntityFrameworkHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new OrdersController();

            var order = new OrderPostModel()
            {
                Date = DateTime.UtcNow,
                Product = new ProductPostModel()
                {
                    Name = "Brik",
                    Price = 40000
                },
                User = new UserPostModel()
                {
                    FirstName = "John",
                    LastName = "cddd",
                    PhoneNumber = "+380912573499"
                }
            };

            var o = controller.CreateOrderRequest(order);
        }
    }
}
