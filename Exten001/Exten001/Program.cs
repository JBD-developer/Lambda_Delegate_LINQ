using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exten001
{
    public static class Exclass
    {
        public static string Ex_ToChangeCase(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var ch in str)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    sb.Append((char)('a' + ch - 'A'));
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    sb.Append((char)('A' + ch - 'a'));
                }
                else
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();

        }

        public static bool Ex_Found(this string str, char ch)
        {
            int position = str.IndexOf(ch);
            return position >= 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is a Extension Method Test";
            string str2 = str.Ex_ToChangeCase();
            Console.WriteLine(str2);
            bool found = str.Ex_Found('z');
            Console.WriteLine(found);
            Console.ReadLine();
        }
    }
}
