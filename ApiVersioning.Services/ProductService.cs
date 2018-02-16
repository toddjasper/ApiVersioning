using ApiVersioning.Business;
using ApiVersioning.DataAccess;
using ApiVersioning.ViewModels;

namespace ApiVersioning.Services
{
    public class ProductService : IProductService
    {
        public ProductViewModel GetProduct()
        {
            IProductDataAccess productDataAccess = new ProductDataAccess();
            var productEntity = productDataAccess.GetProduct();

            var product = new Product(productEntity.Name)
            {
                Sku = productEntity.Sku,
                ImageUrl = productEntity.ImageUrl
            };

            var productViewModel = new ProductViewModel
            {
                Name = product.Name,
                Sku = product.Sku,
                ImageUrl = product.ImageUrl
            };

            return productViewModel;
        }
    }
}
