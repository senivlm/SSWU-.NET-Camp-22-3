using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_PivniukOlha
{
    internal class Buy     
    {    
        internal Product Product { get; set; }
        internal int Quantity { get; set;}
        public Buy(Product productInformation, int quantity)
        {
            Product = productInformation;
            Quantity = quantity;                       
        }
        public double GetTotalPrice()
        {            
            double total_price = Quantity * Product.GetPrice();
            return total_price;
        }
        public override string ToString()
        {            
            return $"Information about product: {Product}, quantity of products: {Quantity}";
        }
    }
}
