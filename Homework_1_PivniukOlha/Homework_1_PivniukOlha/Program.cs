using Homework_1_PivniukOlha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product("milk", 20, 100);
            Product product2 = new Product("water", 10, 200);

            Buy buy1 = new Buy(product1, 3);
            Buy buy2 = new Buy(product2, 7);

            Check check1 = new Check();            

            check1.ShowData(buy1);
            check1.ShowData(buy2);
        }
    }
}
