using AutoMapper;
using Orders.Domain.Models;
using Orders.Domain.Services;
using Orders.Models.PostModels;
using Orders.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Controllers
{
    public class OrdersController
    {
        private readonly OrdersService _ordersService;
        private readonly IMapper _mapper;

        public OrdersController()
        {
            _ordersService = new OrdersService();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductPostModel, ProductModel>();
                cfg.CreateMap<ProductModel, ProductViewModel>();

                cfg.CreateMap<UserPostModel, UserModel>();
                cfg.CreateMap<UserModel, UserViewModel>();

                cfg.CreateMap<OrderPostModel, OrderModel>();
                cfg.CreateMap<OrderModel, OrderViewModel>();
            });

            _mapper = new Mapper(mapperConfig);
        }

        public ProductViewModel CreateProductRequest(ProductPostModel model)
        {
            var product = _mapper.Map<ProductModel>(model);
            var createdProduct = _ordersService.CreateProductRequest(product);

            return _mapper.Map<ProductViewModel>(createdProduct);
        }

        public void DeleteProductByIdRequest(int id)
        {
            _ordersService.DeleteProductByIdRequest(id);
        }

        public UserViewModel CreateUserRequest(UserPostModel model)
        {
            var user = _mapper.Map<UserModel>(model);
            var createdUser = _ordersService.CreateUserRequest(user);

            return _mapper.Map<UserViewModel>(createdUser);
        }

        public void DeleteUserByIdRequest(int id)
        {
            _ordersService.DeleteUserByIdRequest(id);
        }

        public OrderViewModel CreateOrderRequest(OrderPostModel model)
        {
            var order = _mapper.Map<OrderModel>(model);
            var createdOrder = _ordersService.CreateOrderRequest(order);

            return _mapper.Map<OrderViewModel>(createdOrder);
        }

        public void DeleteOrderById(int id)
        {
            _ordersService.DeleteOrderByIdRequest(id);
        }
    }
}
