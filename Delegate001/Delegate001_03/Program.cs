using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate001_03
{
    class RunTest
    {
        private delegate void delegateTest(int i);

        private void LF_DelThis(int p_iVal)
        {
            Console.WriteLine($"LF_Delthis : {p_iVal}");
        }

        private void LF_DelThat(int p_iVal2)
        {
            Console.WriteLine("LF_DelThat : 0x{0:X}", p_iVal2);
            Console.ReadLine();
        }

        public void LF_DelExecution()
        {
            delegateTest del = new delegateTest(LF_DelThis);
            del(1024);

            del = LF_DelThat;
            del(1034);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RunTest test = new RunTest();
            test.LF_DelExecution();
        }
    }
}