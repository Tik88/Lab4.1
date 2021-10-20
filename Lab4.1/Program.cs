using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, Sum;
            Console.Write("Введите число N = ");
            N = Convert.ToInt32(Console.ReadLine());
            Sum = 0;
            for (i = 1; i <= N; i++);
            {
                if (N > 0)
                {
                    Sum = 2 * i - 1;
                    Console.WriteLine("Квадрат числа {0} равен {1}", Sum, Sum * Sum);
                }
              Console.ReadKey();
            }
            

        }
    }
}
