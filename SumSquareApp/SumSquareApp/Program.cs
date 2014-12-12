using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, mid = 0, res = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i*i;
                mid = mid + i;
                 
            }
            res = mid*mid - sum;
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
