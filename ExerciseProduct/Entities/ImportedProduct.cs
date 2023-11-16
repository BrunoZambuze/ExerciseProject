using System;
using System.Globalization;
namespace ExerciseProduct.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; protected set; }

        //Construtores
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customs) : base (name, price)
        {
            CustomsFee = customs;
        }

        //Função para atualizar o preço
        public double TotalPrice()
        {
            return Price += CustomsFee;
        }

        //Sobreposição
        public override string PriceTag()
        {
            return $"{Name} - R${TotalPrice()} (Customs fee: R${CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
