using Homework_2_PivniukOlha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_PivniukOlha
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number of lines: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            MultidimensionalArray.FillMatrixVerticalSnake(n,m);
            Console.WriteLine();           
            MultidimensionalArray.FillMatrixDiagonalSnake(n,m);
            Console.WriteLine();
            MultidimensionalArray.FillMatrixSpiralSnake(n,m);

            Console.WriteLine();
            MultidimensionalArray.FindTheLongestString(n, m);
        }
    }
}
