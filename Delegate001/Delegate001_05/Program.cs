using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate001_05
{
    delegate void dele(int a);
    delegate void dele2(string str);
    class Program
    {
        public static void LF_Method1(int p_iA)
        {
            Console.WriteLine("Method1 " + p_iA);
        }

        public void LF_Method2(int p_iA)
        {
            Console.WriteLine("Method2 " + p_iA);
        }
        static void Main(string[] args)
        {
            dele del;
            del = new dele(LF_Method1);
            del(12);

            Program program = new Program();

            del = program.LF_Method2;
            del(34);


            dele2 del2;
            del2 = Outer.LF_Method3;
            del2("Outer static Method");

            Outer outer = new Outer();
            del2 = outer.LF_Method4;
            del2("Outer Instanse Method");
            Console.ReadLine();
        }
    }
    class Outer
    {
        public static void LF_Method3(string p_sStr)
        {
            Console.WriteLine("LF_Method3 " + p_sStr);
        }

        public void LF_Method4(string p_sStr)
        {
            Console.WriteLine("LF_Method4 " + p_sStr);
        }
    }
}
