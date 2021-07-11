using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate001_02
{
    //Delegate 
    delegate int delMyDelegate(string p_s);
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        private void LF_Test()
        {
            // Delegate 
            delMyDelegate del = new delMyDelegate(LF_StringToParse);
            
            // Delegate Object 
            LF_DelExecution(del);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_s"></param>
        /// <returns></returns>
        private int LF_StringToParse(string p_s)
        {
            Console.WriteLine(p_s.GetType().ToString());
            return int.Parse(p_s);
        }

        /// <summary>
        /// Delegate를 
        /// </summary>
        /// <param name="p_del"></param>
        private void LF_DelExecution(delMyDelegate p_del)
        {
            int i = p_del("123");
            Console.WriteLine(i);
            Console.WriteLine(i.GetType().ToString());
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            new Program().LF_Test();
        }
    }
}
