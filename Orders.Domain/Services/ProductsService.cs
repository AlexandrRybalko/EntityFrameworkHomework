using AutoMapper;
using Orders.DAL.Models;
using Orders.DAL.Repositories;
using Orders.Domain.Models;

namespace Orders.Domain.Services
{
    public class ProductsService
    {
        private readonly ProductsEFRepository _productsEFRepository;
        private readonly IMapper _mapper;

        public ProductsService()
        {
            _productsEFRepository = new ProductsEFRepository();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductModel, Product>();
                cfg.CreateMap<ProductModel, Product>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }

        public ProductModel Create(ProductModel model)
        {
            var product = _mapper.Map<Product>(model);
            var createdProduct = _productsEFRepository.Create(product);

            return _mapper.Map<ProductModel>(createdProduct);
        }

        public void DeleteById(int id)
        {
            _productsEFRepository.DeleteById(id);
        }

        public ProductModel Update(ProductModel model)
        {
            var product = _mapper.Map<Product>(model);
            var updatedProduct = _productsEFRepository.Update(product);

            return _mapper.Map<ProductModel>(updatedProduct);
        }
    }
}
