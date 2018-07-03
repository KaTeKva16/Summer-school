using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину першої сторони трикутника");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть довжину другої сторони трткутника");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть довжину третьої сторони трикутника");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
            {
                if (a >= c)
                {
                    if (a < b + c)
                        Console.WriteLine("Можна скласти трикутник");
                    else Console.WriteLine("Не можна скласти трикутник");
                }
                else if (c >= a && c >= b)
                {
                    if (c < a + b)
                        Console.WriteLine("Можна скласти трикутник");
                    else Console.WriteLine("Не можна скласти трикутник");
                }
            }
            else if (b >= a)
            {
                if (b >= c)
                {
                    if (b < a + c)
                        Console.WriteLine("Можна скласти трикутник");
                    else Console.WriteLine("Не можна скласти трикутник");
                }
                else if (b < c)
                {
                    if (c < a + b)
                        Console.WriteLine("Можна скласти трикутник");
                    else Console.WriteLine("Не можна скласти трикутник");
                }
            }

        }
    }
}
