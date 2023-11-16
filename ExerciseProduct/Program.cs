using ExerciseProduct.Entities;
using System;
namespace ExerciseProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());
            List<Product> ListProduct= new List<Product>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nProduct #{i + 1} data:");
                Console.Write("Commom, Used or Imported? (c/u/i):");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price: R$");
                double price = double.Parse(Console.ReadLine());
                if (resp == 'i' || resp == 'I')
                {
                    Console.Write("Custom fee:");
                    double custom = double.Parse(Console.ReadLine());
                    ListProduct.Add(new ImportedProduct(name, price, custom));
                }
                else if (resp == 'u' || resp == 'U')
                {
                    Console.Write("Manufacture Date (dd/mm/yyyy):");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    ListProduct.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    ListProduct.Add(new Product(name, price));
                }
            }
            Console.WriteLine("\n---PRICE TAGS---");
            foreach (Product prod in ListProduct)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}