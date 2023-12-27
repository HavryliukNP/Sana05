using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Product
    {
        protected string Name { get; set; }
        protected double Price { get; set; }
        protected Currency Cost { get; set; }
        protected int Quantity { get; set; }
        protected string Producer { get; set; }
        protected double Weight { get; set; }

        public Product(string name, int price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public double GetPriceInUAH()
        {
            double priceInUAH = Price * Cost.ExRate;
            return priceInUAH;
        }
        public double GetTotalPriceInUAH()
        {
            double totalPriceInUAH = GetPriceInUAH() * Quantity;
            return totalPriceInUAH;
        }
        public double GetTotalWeight()
        {
            double totalWeight = Weight * Quantity;
            return totalWeight;
        }
        public Product()
        {
            Cost = new Currency();
        }
        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = product.Cost;
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }
        public Product(Currency cost)
        {
            Cost = new Currency(cost);
        }
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
    }
}
