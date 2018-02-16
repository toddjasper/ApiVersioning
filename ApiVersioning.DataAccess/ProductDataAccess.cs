using ApiVersioning.DataAccess.Entities;

namespace ApiVersioning.DataAccess
{
    public class ProductDataAccess : IProductDataAccess
    {
        public ProductEntity GetProduct()
        {
            return new ProductEntity {Name = "Sample Product", Sku = "ABC123-B", ImageUrl = "/image.jpg"};
        }
    }
}
