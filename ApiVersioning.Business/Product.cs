namespace ApiVersioning.Business
{
    public class Product
    {
        public string Name { get; private set; }
        public string Sku { get; set; }
        public string ImageUrl { get; set; }

        public Product(string productName)
        {
            Name = productName;
        }
    }
}
