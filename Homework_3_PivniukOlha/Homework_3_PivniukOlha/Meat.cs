using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_PivniukOlha
{
    public class Meat : Product
    {           
        public CategoryProduct Category { get; set; }
        public KindProduct Kind { get; set; }

        public Meat(string name, double price, CategoryProduct category, KindProduct kind) : base (name, price)
        {           
            Category = category;
            Kind = kind;
        }
        public override string ToString()
        {
            return $"Name of product: {Name}, price: { Price}, category of products: {Category}, kind of product: {Kind}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Meat)
            {
                return false;
            }
            else
            {
                Meat other = (Meat)obj;
                return Name == other.Name;
            }
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Category, Kind);
        }
        public override void ChangePrice(double percent)
        {
            double newPrice;
            if (Category == CategoryProduct.HigherGrade)
            {
                newPrice = Price * (1 + percent / 100) + 10;
                Price = newPrice;
            }
            else if (Category == CategoryProduct.SecondGrade)
            {
                newPrice = Price * (1 + percent / 100) + 20;
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
