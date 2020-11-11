using Orders.Controllers;
using Orders.Models.PostModels;
using Orders.Models.ViewModels;
using System;
using System.Collections.Generic;

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
                Products = new List<ProductPostModel>()
                {
                    new ProductPostModel()
                    {
                        Name = "Brik",
                        Price = 40000
                    },
                    new ProductPostModel()
                    {
                        Name = "Wood",
                        Price = 40000
                    }
                },
                User = new UserPostModel()
                {
                    FirstName = "John",
                    LastName = "cddd",
                    PhoneNumber = "+380912573499"
                }
            };

            var a = controller.Create(order);
        }
    }
}
