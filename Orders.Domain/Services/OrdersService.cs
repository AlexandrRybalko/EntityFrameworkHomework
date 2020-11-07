using AutoMapper;
using Orders.DAL.Models;
using Orders.DAL.Repositories;
using Orders.Domain.Models;

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
                cfg.CreateMap<OrderModel, Order>();
                cfg.CreateMap<OrderModel, Order>().ReverseMap();

                cfg.CreateMap<ProductModel, Product>();
                cfg.CreateMap<ProductModel, Product>().ReverseMap();

                cfg.CreateMap<UserModel, User>();
                cfg.CreateMap<UserModel, User>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }

        public OrderModel Create(OrderModel model)
        {
            var order = _mapper.Map<Order>(model);
            var createdOrder = _ordersEFRepository.Create(order);
            var result = _mapper.Map<OrderModel>(createdOrder);

            return result;
        }

        public void DeleteById(int id)
        {
            _ordersEFRepository.DeleteById(id);
        }

        public OrderModel Update(OrderModel model)
        {
            var order = _mapper.Map<Order>(model);
            var updatedOrder = _ordersEFRepository.Update(order);

            return _mapper.Map<OrderModel>(updatedOrder);
        }
    }
}
