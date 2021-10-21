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
            Double N, i, S;
            Console.Write("Введите число N = ");
            N = Convert.ToInt32(Console.ReadLine());
            S = Math.Pow(N, 2) - 2 * N + 1; 
            for (i = S; i <= N; i += S);
            {                

                if (N > 0)
                {                    
                    Console.WriteLine("Квадрат числа {0} равен {1}", N, i+ (2 * N - 1));
                    N--;
                    Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine("Ошибка!!!");
                    return;
                }
                
            }

        }
    }
}
