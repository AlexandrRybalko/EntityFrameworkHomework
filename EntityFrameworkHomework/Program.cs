using Orders.Controllers;
using Orders.Models.PostModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var productModel = new ProductPostModel()
            {
                Name = "BrickBaz",
                Price = 40000
            };

            var userModel = new UserPostModel()
            {
                FirstName = "bddd",
                LastName = "cddd",
                PhoneNumber = "+380912573499"
            };

            var controller = new OrdersController();
            var product = controller.CreateProductRequest(productModel);
            var user = controller.CreateUserRequest(userModel);

            //var o = controller.CreateOrderRequest(order);
        }
    }
}
