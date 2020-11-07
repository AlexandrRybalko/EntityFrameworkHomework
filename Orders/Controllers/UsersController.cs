using AutoMapper;
using Orders.Domain.Models;
using Orders.Domain.Services;
using Orders.Models.PostModels;
using Orders.Models.ViewModels;

namespace Orders.Controllers
{
    public class UsersController
    {
        private readonly UsersService _usersService;
        private readonly IMapper _mapper;

        public UsersController()
        {
            _usersService = new UsersService();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserPostModel, UserModel>();
                cfg.CreateMap<UserModel, UserViewModel>();
                cfg.CreateMap<UserModel, UserViewModel>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }

        public UserViewModel Create(UserPostModel model)
        {
            var user = _mapper.Map<UserModel>(model);
            var createdUser = _usersService.Create(user);

            return _mapper.Map<UserViewModel>(createdUser);
        }

        public void DeleteById(int id)
        {
            _usersService.DeleteById(id);
        }

        public UserViewModel Update(UserViewModel model)
        {
            var user = _mapper.Map<UserModel>(model);
            var updatedUser = _usersService.Update(user);

            return _mapper.Map<UserViewModel>(updatedUser);
        }
    }
}
