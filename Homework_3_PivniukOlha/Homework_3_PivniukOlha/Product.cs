using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_PivniukOlha
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetPrice()
        {
            return Price;
        }        
        public override string ToString()
        {
            return $"Name: {Name}, price: {Price}";
        }        
        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Product)
            {
                return false;
            }
            else
            {
                Product other = (Product)obj; 
                return this.Name == other.Name;
            }            
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
        public virtual void ChangePrice(double percent)
        {
            double newPrice = Price * (1 + percent / 100);
            Price = newPrice;            
        }

    }
}