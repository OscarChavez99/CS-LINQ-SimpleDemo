using CS_LINQ_SimpleDemo.Models;

namespace CS_LINQ_SimpleDemo.LinqQueries
{
    internal static class LinqQueries
    {
        public static void CreateQueries()
        {
            List<Product> products = Lists.Lists.GetProductsList();
            List<Brand>   brands   = Lists.Lists.GetBrandsList();

            // ------------ Products with prices greater than 1000 ------------
            var highPricedProducts = from p in products
                                     where p.Price > 1000
                                     orderby p.Price
                                     select p.ProductName;

            // ---------------- Sony products ----------------
            var sonyProducts = from p in products
                               where p.BrandName == "Sony"
                               select p.ProductName;

            // ------------- Joining two lists with BrandName -------------
            var japaneseProducts = from p in products
                                   join b in brands
                                   on p.BrandName equals b.BrandName
                                   where b.Country == "Japan"
                                   select new
                                   {
                                       p.ProductName,
                                       p.BrandName,
                                       b.Country
                                   };
            PrintQueries(highPricedProducts, sonyProducts, japaneseProducts);
        }

        public static void PrintQueries(IEnumerable<string> highPricedProducts,
            IEnumerable<string> sonyProducts, IEnumerable<object> japaneseProducts)
        {
            Console.WriteLine("High Priced Products: ");
            foreach (var product in highPricedProducts)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nSony Products: ");
            foreach (var product in sonyProducts)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nJapanese Products: ");
            foreach (var product in japaneseProducts)
            {
                Console.WriteLine(product);
            }
        }
    }
}
