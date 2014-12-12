using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 600851475143, b = 0;

            for (int i = 3; i < 1000; i++)
            {
                if (a%i==0)
                {
                    b = i;
                }
            }

            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
