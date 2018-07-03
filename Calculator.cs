using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("перше число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("друге число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введіть дію(+,-,/,*, %)");
            char x = Convert.ToChar(Console.ReadLine());
            if (x == '+')
                Console.WriteLine(a + b);
            else if (x == '-')
                Console.WriteLine(a - b);
            else if (x == '*')
                Console.WriteLine(a * b);
            else if (x == '/')
            {
                if (b == 0)
                    Console.WriteLine("На 0 ділити не можна!");
                else
                    Console.WriteLine(a / b);
            }
            else if (x == '%')
                Console.WriteLine(a % b);

        }
    }
}
