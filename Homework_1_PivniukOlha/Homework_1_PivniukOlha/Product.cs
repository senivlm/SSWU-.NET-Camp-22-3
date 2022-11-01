using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_PivniukOlha
{
    internal class Product
    {
        readonly string _name;
        readonly double _price;
        readonly double _weight;        
        
        public Product(string name, double price, double weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
        public string GetName()
        {
            return _name;
        }
        public double GetPrice()
        {
            return _price;
        }
        public double GetWeight()  
        {
            return _weight;
        }
        public override string ToString()
        {            
            return $"Name: {_name}, price: {_price}, weight {_weight}";
        }
    }
}
