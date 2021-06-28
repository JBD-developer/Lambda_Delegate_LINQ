using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda001_02
{
    class Program
    {
        delegate bool LambdaisEven(int p_iNum);
        
        static void Main(string[] args)
        {
            //usiong Lambda Expression 
            Func<int, bool> isEven = x => x % 3 == 0;
            Console.WriteLine($"{32} % 3 == 0 ? : {isEven(32)}");
            Console.WriteLine($"{44} % 3 == 0 ? : {isEven(44)}");

            LambdaisEven lambda = (a) => a % 2 == 0;
            Console.WriteLine($"{2} % 2 == 0? : {lambda(2)}");
            Console.WriteLine($"{3} % 2 == 0? : {lambda(3)}");

            //using Lambda Statement
            Action<string> greet = name =>
            {
                var message = $"Hello {name}";
                Console.WriteLine(message);
            };
            greet("CSharp");
  
            Console.ReadLine();
        }
    }
}
