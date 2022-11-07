using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_PivniukOlha
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Storage storage = new Storage(6);           

            storage.Print();
            Console.WriteLine();
            Console.WriteLine($"Information about all meat products: {storage.FindAllMeatProducts()}");
        }
    }      
}
