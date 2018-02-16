using ApiVersioning.DataAccess.Entities;

namespace ApiVersioning.DataAccess
{
    public interface IProductDataAccess
    {
        ProductEntity GetProduct();
    }
}
