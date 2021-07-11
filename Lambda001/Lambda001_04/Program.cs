using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda001_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNum = new List<int> { 1, 3, 4, 5, 6, 111, 341, 4 };

            Console.WriteLine("The list");

            foreach (var num in listNum)
            {
                Console.WriteLine($"original value : {num} ");
            }

            var selectNum = listNum.Select(x => x * x);
            Console.WriteLine();
            Console.WriteLine("Number multiply original value");
            
                foreach (var num in selectNum)
            {
                Console.WriteLine($"multiply original value : {num}");
            }
            
            List<int> listNumDivBy3 = listNum.FindAll(x => (x % 3) == 0);
            Console.WriteLine();
            Console.WriteLine("Numbers divisible by 3 ");

            foreach (var num in listNumDivBy3)
            {
                Console.WriteLine($"divided by 3 equals 0 value  : {num}");
            }
            Console.ReadLine();

        }
    }
}
