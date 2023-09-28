using Lab4_3;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var brands = new List<Brand>()
            {
                new Brand { ID = 1, Name = "Công ty AAA" },
                new Brand { ID = 2, Name = "Công ty BBB" },
                new Brand { ID = 3, Name = "Công ty CCC" },
            };

        var products = new List<Product>()
            {
                new Product(1, "Bàn Trà", 400, new string[] { "Xám", "Xanh" }, 2),
                new Product(2, "Tranh treo", 400, new string[] { "Vàng", "Xanh" }, 1),
                new Product(3, "Đèn trùm", 500, new string[] { "Trắng" }, 3),
                new Product(4, "Bàn học", 200, new string[] { "Trắng", "Xanh" }, 1),
                new Product(5, "Túi da", 300, new string[] { "Đỏ", "Đen", "Vàng" }, 2),
                new Product(6, "Giường ngủ", 500, new string[] { "Trắng" }, 2),
                new Product(7, "Tủ áo", 600, new string[] { "Trắng" }, 3),
                new Product(8, "Ghế", 100, new string[] { "Xanh" }, 4),

            };

        var productsWithPrice400 = from product in products
                                   join brand in brands on product.Brand equals brand.ID
                                   where product.Price == 400
                                   select new
                                   {
                                       name = product.Name,
                                       brand = brand.Name,
                                       price = product.Price
                                   };
        Console.WriteLine("\nProducts with a price of 400:");
        foreach (var item in productsWithPrice400)
        {
            Console.WriteLine($"{item.name,10}{item.price,4}{item.brand,12}");
        }

        var productsWithYellow = from product in products
                      join brand in brands on product.Brand equals brand.ID
                                 where product.Colors.Contains("Vàng")
                                 select new
                      {
                          name = product.Name,
                          brand = brand.Name,
                          price = product.Price,
                          colors = string.Join(",", product.Colors)
                      };
        Console.WriteLine("\nProducts contain the color yellow:");
        foreach (var item in productsWithYellow)
        {
            Console.WriteLine($"{item.name,10} {item.price,4} {item.colors,12} {item.brand,12}");
        }

        var productsDescendingByPrice = from product in products
                                   join brand in brands on product.Brand equals brand.ID into t
                                   from brand in t.DefaultIfEmpty()
                                        orderby product.Price descending
                                        select new
                                   {
                                       name = product.Name,
                                            brand = (brand == null) ? "NO-BRAND" : brand.Name,
                                            price = product.Price,
                                       colors = string.Join(",", product.Colors)
                                   };
        Console.WriteLine("\nProducts in descending order of price:");
        foreach (var item in productsDescendingByPrice)
        {
            Console.WriteLine($"{item.name,10}{item.price,4} {item.colors,12} {item.brand,12}");
        }
    }
}