using AutoMapper;
using Orders.Domain.Models;
using Orders.Domain.Services;
using Orders.Models.PostModels;
using Orders.Models.ViewModels;

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
                cfg.CreateMap<OrderPostModel, OrderModel>();
                cfg.CreateMap<OrderModel, OrderViewModel>();
                cfg.CreateMap<OrderModel, OrderViewModel>().ReverseMap();

                cfg.CreateMap<ProductPostModel, ProductModel>();
                cfg.CreateMap<ProductModel, ProductViewModel>();
                cfg.CreateMap<ProductModel, ProductViewModel>().ReverseMap();

                cfg.CreateMap<UserPostModel, UserModel>();
                cfg.CreateMap<UserModel, UserViewModel>();
                cfg.CreateMap<UserModel, UserViewModel>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }

        public OrderViewModel Create(OrderPostModel model)
        {
            var order = _mapper.Map<OrderModel>(model);
            var createdOrder = _ordersService.Create(order);

            return _mapper.Map<OrderViewModel>(createdOrder);
        }

        public void DeleteById(int id)
        {
            _ordersService.DeleteById(id);
        }

        public OrderViewModel Update(OrderViewModel model)
        {
            var order = _mapper.Map<OrderModel>(model);
            var updatedOrder = _ordersService.Update(order);

            return _mapper.Map<OrderViewModel>(updatedOrder);
        }
    }
}
