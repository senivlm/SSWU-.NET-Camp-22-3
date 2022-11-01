using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_PivniukOlha
{
    internal class Check 
    {        
        public void ShowData(Buy buy) 
        {
            Console.WriteLine ($"You buy products: {buy.ToString()}, with total price: {buy.GetTotalPrice()}");
        }        
    }
}

