using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace ExerciseProduct.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; protected set; }

        //Construtores
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime date) : base (name, price)
        {
            ManufactureDate = date;
        }

        //Sopreposição
        public override string PriceTag()
        {
            return $"{Name} (used) - R$ {Price} (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
