using AutoMapper;
using Orders.DAL.Models;
using Orders.DAL.Repositories;
using Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Domain.Services
{
    public class OrdersService
    {
        private readonly OrdersEFRepository _ordersEFRepository;
        private readonly IMapper _mapper;

        public OrdersService()
        {
            _ordersEFRepository = new OrdersEFRepository();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductModel, Product>();
                cfg.CreateMap<ProductModel, Product>().ReverseMap();

                cfg.CreateMap<UserModel, User>();
                cfg.CreateMap<UserModel, User>().ReverseMap();

                cfg.CreateMap<OrderModel, Order>();
                cfg.CreateMap<OrderModel, Order>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }

        public ProductModel CreateProductRequest(ProductModel model)
        {
            var product = _mapper.Map<Product>(model);        
            var createdProduct = _ordersEFRepository.CreateProduct(product);

            return _mapper.Map<ProductModel>(createdProduct);
        }

        public void DeleteProductByIdRequest(int id)
        {
            _ordersEFRepository.DeleteProductById(id);
        }

        public UserModel CreateUserRequest(UserModel model)
        {
            var user = _mapper.Map<User>(model);
            var createdUser = _ordersEFRepository.CreateUser(user);

            return _mapper.Map<UserModel>(createdUser);
        }

        public void DeleteUserByIdRequest(int id)
        {
            _ordersEFRepository.DeleteUserById(id);
        }

        public OrderModel CreateOrderRequest(OrderModel model)
        {
            var order = _mapper.Map<Order>(model);
            var createdOrder = _ordersEFRepository.CreateOrder(order);
            var result = _mapper.Map<OrderModel>(createdOrder);
            return result;
        }

        public void DeleteOrderByIdRequest(int id)
        {
            _ordersEFRepository.DeleteOrderById(id);
        }
    }
}
