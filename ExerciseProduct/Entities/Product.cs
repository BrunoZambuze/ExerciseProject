using System;
using System.Globalization;

namespace ExerciseProduct.Entities
{
    internal class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        //Construtores
        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //Função de Tag do produto
        public virtual string PriceTag()
        {
            return $"{Name} - R$ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
