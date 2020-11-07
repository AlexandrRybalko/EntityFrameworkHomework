using AutoMapper;
using Orders.DAL.Models;
using Orders.DAL.Repositories;
using Orders.Domain.Models;

namespace Orders.Domain.Services
{
    public class UsersService
    {
        private readonly UsersEFRepository _usersEFRepository;
        private readonly IMapper _mapper;

        public UsersService()
        {
            _usersEFRepository = new UsersEFRepository();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserModel, User>();
                cfg.CreateMap<UserModel, User>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }

        public UserModel Create(UserModel model)
        {
            var user = _mapper.Map<User>(model);
            var createdUser = _usersEFRepository.Create(user);

            return _mapper.Map<UserModel>(createdUser);
        }

        public void DeleteById(int id)
        {
            _usersEFRepository.DeleteById(id);
        }

        public UserModel Update(UserModel model)
        {
            var user = _mapper.Map<User>(model);
            var updatedUser = _usersEFRepository.Update(user);

            return _mapper.Map<UserModel>(updatedUser);
        }
    }
}
