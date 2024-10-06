// See https://aka.ms/new-console-template for more information

using System;


namespace HelloWorld
{
  static class Program
  {
    static void Main(string[] args)
    {
            using (var context = new AppDbContext())
            {
                // Add a new product
                var product = new Product { Name = "Sample Product", Price = 10.99M };
                context.Products.Add(product);
                context.SaveChanges();

                // Query the product
                var products = context.Products.ToList();
                foreach (var p in products)
                {
                    Console.WriteLine($"Product: {p.Name}, Price: {p.Price}");
                }
            }

        }
  }
}

