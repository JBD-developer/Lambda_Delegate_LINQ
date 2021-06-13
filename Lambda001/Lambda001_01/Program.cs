using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda001_01
{
    class Program
    {
        delegate string Concatenate(string [] args);
        static void Main(string[] args)
        {
            Concatenate concat = 
                (arr) => 
                {
                    string result = "";
                    foreach (string str in arr)
                    {
                        result += str;
                    }
                    return result;
                };

            Console.WriteLine(concat(args));
        }
    }
}
