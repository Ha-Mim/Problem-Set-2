using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFiboApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2,sum = 1;
            while (a < 4000000)
            {
                if (a%2 == 0)
                {
                    sum = sum + a;
                }
                int temp = a;
                a = b;
                b = temp + a;
             
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
