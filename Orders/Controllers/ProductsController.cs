using AutoMapper;
using Orders.Domain.Models;
using Orders.Domain.Services;
using Orders.Models.PostModels;
using Orders.Models.ViewModels;

namespace Orders.Controllers
{
    public class ProductsController
    {
        private readonly ProductsService _productsService;
        private readonly IMapper _mapper;

        public ProductsController()
        {
            _productsService = new ProductsService();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductPostModel, ProductModel>();
                cfg.CreateMap<ProductModel, ProductViewModel>();
                cfg.CreateMap<ProductModel, ProductViewModel>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }

        public ProductViewModel Create(ProductPostModel model)
        {
            var product = _mapper.Map<ProductModel>(model);
            var createdProduct = _productsService.Create(product);

            return _mapper.Map<ProductViewModel>(createdProduct);
        }

        public void DeleteById(int id)
        {
            _productsService.DeleteById(id);
        }

        public ProductViewModel Update(ProductViewModel model)
        {
            var product = _mapper.Map<ProductModel>(model);
            var updatedProduct = _productsService.Update(product);

            return _mapper.Map<ProductViewModel>(updatedProduct);
        }
    }
}
