using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_PivniukOlha
{
    internal class Dairy_products : Product
    {               
        public int ExpirationDateInDays { get; set; }

        public Dairy_products(string name, double price, int expirationDateInDays) : base(name, price)
        {
            ExpirationDateInDays = expirationDateInDays;          
        }
        public override string ToString()
        {
            return $"Name of product: {Name}, price: {Price}, Expiration date in days: {ExpirationDateInDays}";
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Dairy_products);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, ExpirationDateInDays);
        }
        public override void ChangePrice(double percent)
        {
            double newPrice;
            if (ExpirationDateInDays < 2)
            {
                newPrice = Price * (1 + percent / 100) - 30;
                Price = newPrice;
            }
            else if (ExpirationDateInDays < 5)
            {
                newPrice = Price * (1 + percent / 100) - 10;
                Price = newPrice;
            }
            else
            {
                newPrice = Price * (1 + percent / 100);
                Price = newPrice;
            }            
        }
    }
}
