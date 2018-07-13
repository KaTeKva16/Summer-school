using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0, pr = 1;
            while (a != 0)
            {
                sum = sum + (a % 10);
                pr = pr * (a % 10);
                a = a / 10;
            }
            Console.WriteLine("Сума = {0}\nМноження цифр = {1}", sum, pr);
        }
    }
}