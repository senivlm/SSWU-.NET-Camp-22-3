using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_PivniukOlha
{
    internal class Check
    {
        public virtual void ShowData(Product product)
        {
            Console.WriteLine($"The product price with the original price has been changed to new price: {product.ToString()}");        
        }
    }
}
