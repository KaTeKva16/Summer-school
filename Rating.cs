using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть оцінку учня(від 1 до 100");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 90)
                Console.WriteLine("A");
            else if (a >= 75)
                Console.WriteLine("B");
            else if (a >= 65)
                Console.WriteLine("C");
            else if (a >= 60)
                Console.WriteLine("D");
            else if (a < 60)
                Console.WriteLine("E");

        }
    }
}
