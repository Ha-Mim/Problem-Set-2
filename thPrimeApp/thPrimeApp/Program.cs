using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thPrimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int b=0;
            for (int i = 1; i < 100000; i++)
            {
                for (int j = 2; j < 10003;j++)
                {
                    if (i%j != 0 && j%2!=0)
                    {
                        b = j;
                    }
                }
                Console.WriteLine(b);
                Console.ReadLine();


            }
        }
    }
}
