using System;
using System.Threading.Tasks;
using System.Linq;

namespace LinqProject
{
    class program
    {
        public static void Main(string[] args)
        {
            List<Category> categories = new List<Category>();
            {
                new Category { CategoryId = 1, CategoryName = "Computer" },
                new Category { CategoryId = 2, CategoryName = "Phone" },
            };
            List<Product> products = new List<Product>();
            {
                new Product { ProductId = 1 , CategoryId = 1, ProductName = "acer", QuantityPerUnit = "32 GB", UnitINStock = "", UnitPrice = 10000, }
                new Product { ProductId = 2 , CategoryId = 1 ,ProductName = "casper", QuantityPerUnit = "32 GB", UnitINStock = "", UnitPrice = 10000, }
                new Product { ProductId = 3 , CategoryId = 2, ProductName = "lwnovo", QuantityPerUnit = "32 GB", UnitINStock = "", UnitPrice = 10000, }
                new Product { ProductId = 4 , CategoryId = 2 ,ProductName = "Iphone", QuantityPerUnit = "32 GB", UnitINStock = "", UnitPrice = 10000, }
            };

            Console.WriteLine("Algorıthms------------------------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitINStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("lINQ ---------------------------");
            var result = products.Where(product => product.UnitPrice > 5000 && product.UnitINStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            GetProducts(products);
        }


        static List<Product> GetProducts(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 5000 && product.UnitINStock > 3);
        }
           
            
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in result)
            {
                if (product.UnitPrice > 5000 && product.UnitINStock > 3)
                {
                    filteredProduct.Add(product);
                    //Console.WriteLine(product.ProductName);
                }

}
return filteredProducts;
        }
        static List<Product> GetProducts(List<Product> products)
{

}
class Product
{
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public string UnitPrice { get; set; }
    public string UnitINStock { get; set; }
    public int CategoryId { get; internal set; }
}
class Category
{
    public string CategoryId { get; set; }
    public string CategoryName { get; set; }
}
    }
}

