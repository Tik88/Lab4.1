using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region(Ввод данных)
            Console.Write("Введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int n = 0;
            #endregion
            //квадраты на стороне А
            while (a >= c)
            {
                a -= c;
                k++;
            }
            //квадраты на стороне В
            while (b >= c)
            {
                b -= c;
                n++;
            }
            int count = 0;
            for (int i = 0; i < k; i++)
                count += n;
            Console.WriteLine("Количество квадратов = " + count);
            Console.ReadKey();
        }

    }
}
