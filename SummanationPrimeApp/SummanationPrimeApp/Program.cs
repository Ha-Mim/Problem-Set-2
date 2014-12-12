using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummanationPrimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 2,sum = 2;
            for (int i = 4; i <100000; i++)
            {
                for ( j = 3; j < i; j++)
                {
                    if (i%j == 0 && i%2!=0)
                    {
                       // Console.WriteLine(j);
                        sum = sum + j;
                        
                        
                    }
                }
            }
           
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
