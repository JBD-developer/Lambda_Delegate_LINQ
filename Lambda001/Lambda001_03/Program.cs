using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda001_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //using Func 
            Func<int> func1 = () => 10;
            Console.WriteLine($"func1() : {func1()}");

            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine($"func2() : {func2(3)}");

            Func<double, double, double> func3 = (x, y) => x/y;
            Console.WriteLine($"func3() : {func3(4, 5)}");
            
            Console.ReadLine();
        }
    }
}
