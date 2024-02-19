using CS_LINQ_SimpleDemo.Models;

namespace CS_LINQ_SimpleDemo.Lists
{
    internal static class Lists
    {
        public static List<Product> GetProductsList()
        {
            List<Product> products = new()
            {
                new Product { ProductName = "DualSense", BrandName = "Sony", Price = 99.9f},
                new Product { ProductName = "PlayStation", BrandName = "Sony", Price = 500.0f},
                new Product { ProductName = "iPhone", BrandName = "Apple", Price = 1000.5f},
                new Product { ProductName = "Mac", BrandName = "Apple", Price = 1200.5f}
            };

            return products;
        }

        public static List<Brand> GetBrandsList()
        {
            List<Brand> brands = new()
            {
                new Brand { BrandName = "Apple", Country = "USA" },
                new Brand { BrandName = "Sony", Country = "Japan"}
            };

            return brands;
        }
    }
}
