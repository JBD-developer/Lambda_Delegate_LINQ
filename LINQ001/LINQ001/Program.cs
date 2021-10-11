/*************************************
PROJECT NAME        : LINQ 
PROJECT INFORMATION : LINQ  
CREATE DATE         : 2021-10-12 
WRITER              : J
MODIFIER            : 
MODIFY DATE         : 
**************************************/

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LINQ001
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayName = new string[] { "KIM", "PARK", "JEONG", "LEE", "HAN" };
            LF_Search_String_Length(arrayName);
            int[] arrayNum = new int[] { 1, 2, 3, 4, 5, 6, 12, 8, 99 };
            LF_Search_Multiple_Of_Three(arrayNum);

            Console.ReadLine();
        }

        private static void LF_Search_String_Length(String[] p_sArray )
        {
            var nameQuery = from name in p_sArray
                            where name.Length == 3
                            select name;
            foreach (string name in nameQuery)
            {
                Console.WriteLine($"Name : {name}");
            }
        } 

        private static void LF_Search_Multiple_Of_Three(int[] p_iArray)
        {
            var numQuery = from num in p_iArray
                           where (num % 3) == 0
                           select num;
            foreach (var num in numQuery)
            {
                Console.WriteLine($"Num : {num}");
            }
            Console.ReadLine();
        }
    }
}
