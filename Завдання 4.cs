using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i * i <= a; i++)
            {
                Console.Write("{0} ", i*i);
            }
        }
    }
}
