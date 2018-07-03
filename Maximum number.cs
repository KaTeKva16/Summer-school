using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть третє число");
            int c = Convert.ToInt32(Console.ReadLine());
            int max;
            if (a >= b)
            {
                if (a >= c)
                {
                    max = a;
                    Console.WriteLine("Найбільше число - {0}", max);
                }
                else if (a <= c)
                {
                    max = c;
                    Console.WriteLine("Найбільше число - {0}", max);
                }
            }
            else if (b >= a)
            {
                if (b >= c)
                {
                    max = b;
                    Console.WriteLine("Найбільше число - {0}", max);
                }
                else if (b < c)
                {
                    max = c;
                    Console.WriteLine("Найбільше число - {0}", max);
                }
            }
        }
    }
}
