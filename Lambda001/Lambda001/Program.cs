using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda001
{
    class Program
    {
        delegate int Calculate(int p_a, int p_b);
        delegate void DoShoething();
        static void Main(string[] args)
        {
            Calculate calc = (a, b) => a + b;

            Console.WriteLine($"{3} + {4} : {calc(3, 4)}");

            DoShoething DoIt = () =>
            {
                Console.WriteLine("Lambda Test");
                Console.WriteLine("Lambda Test01");
                Console.WriteLine("Lambda Test02");
            };

            DoIt();
        
        }
    }
}
