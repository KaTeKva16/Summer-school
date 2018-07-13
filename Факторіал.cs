using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Факторіал
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            int a = Convert.ToInt32(Console.ReadLine());
            int res = 1;
            for (int i= 1; i<=a;i++)
            {
                res = res * i;
            }
            Console.WriteLine(res);
        }
    }
}
