using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть будь який рік");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 400 == 0 || (a % 4 == 0 && a % 100 != 0))
                Console.WriteLine("Рік високосний");
            else Console.WriteLine("Рік не високосний");
        }
    }
}