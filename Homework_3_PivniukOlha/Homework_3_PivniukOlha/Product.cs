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
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj is Product)
            {
                Product product = (Product)obj;
                return
                    (this.Name == product.Name);
            }
            return false;
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