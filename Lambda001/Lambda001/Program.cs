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
        delegate void DoSomething();
        delegate String Concatenate(string[] args);
        static void Main(string[] args)
        {
            Calculate calc = (a, b) => a + b;

            Console.WriteLine($"{3} + {4} : {calc(3, 4)}");

            DoSomething DoIt = () =>
            {
                Console.WriteLine("Lambda Test");
                Console.WriteLine("Lambda Test01");
                Console.WriteLine("Lambda Test02");
            };

            DoIt();

            Concatenate concat =

                (array) =>
                {
                    string result = "";
                    foreach (string str in array)
                    {
                        result += str;
                    }
                    return result;
                };  
        }
    }
}
