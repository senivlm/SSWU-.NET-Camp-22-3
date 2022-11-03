using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_PivniukOlha
{
    internal class MeаtCheck : Check
    {
        public override void ShowData(Product product)
        {
            Console.WriteLine($"The product price with the original price: {product.ToString()}");
        }
    }
}
