using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_PivniukOlha
{
    public class MultidimensionalArray
    {//не правильна організація класу. Прохання залишитись для пояснень
        public static void FillMatrixVerticalSnake(int n, int m)
        {                       
            int[,] myArray = new int[n, m]; 
            for (int j = 0, c = 1; j < m; j++)
            {
                for(int i = 0; i < n; i++, c++)
                {
                    if(j % 2 == 0)
                    {
                        myArray[i,j] = c;
                    }
                    else
                    {
                        myArray[n - 1 - i,j] = c;
                    } 
                }
            }
 
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write("{0,4}", myArray[i, j]);
                }
                Console.WriteLine();
            }            
        }
        public static void FillMatrixDiagonalSnake(int n, int m)
        {
            int[,] myArray = new int[n, m];
            for (int i = 0, v = 0; i < n + m - 1; i++)
            {
                int r, c;//не ініціалізовані змінні
                if (i % 2 == 1)
                {
                    r = i < m ? 0 : i - m + 1;
                    c = i < m ? i : m - 1;
                }
                else
                {
                    r = i < n ? i : n - 1;
                    c = i < n ? 0 : i - n + 1;
                }..
                while (r < n && r >= 0 && c < m && c >= 0)
                {
                    myArray[i % 2 == 0 ? r-- : r++, i % 2 == 0 ? c++ : c--] = ++v;
                }
            }
            // друк і заповнення мають бути різними методами.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,4}", myArray[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void FillMatrixSpiralSnake(int n, int m)
        {// Алгоритмічно не правильно
            int[,] myArray = new int[n, m];
            int start = 1;
            int k = 0, l = 0, x = n * m + 1;
            while (true)
            {
                for (int i = k; i < m - k; i++) myArray[l, i] = start++; if (start == x) break;
                l++;
                for (int i = l; i < n - l; i++) myArray[i, m - k - 1] = start++; if (start == x) break;
                for (int i = m - k - 1; i >= k; i--) myArray[n - l, i] = start++; if (start == x) break;
                for (int i = n - l - 1; i >= l; i--) myArray[i, k] = start++; if (start == x) break;
                k++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,4}", myArray[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void FindTheLongestString(int n, int m)
        {
            int[,] myArray = new int[n, m];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    myArray[i, j] = random.Next(0,16);
                    Console.Write("{0,4}", myArray[i, j]);
                }
                Console.WriteLine();
            }

            int lineNum = -1;
            int maxCount = 0;

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < m - 1; j++)
                {
                    if (myArray[i, j] != myArray[i, j + 1]) continue;
                    count++;
                }
                if (maxCount >= count) continue;
                maxCount = count;
                lineNum = i;

            }
            Console.WriteLine($"The number of the line containing the longest series of identical elements: {lineNum}");
        }
    }
}
