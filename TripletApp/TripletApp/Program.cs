using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripletApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int d=0;
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 2; b < 1000 - a; b++)
                {
                    int c = 1000 - a - b;



                    if (a*a + b*b == c*c && a < b && b < c)
                    {
                        d = d + a*b*c;

                    }
                }
            }
            Console.WriteLine(d);
            Console.ReadLine();

        }
    }
}
