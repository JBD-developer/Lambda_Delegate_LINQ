using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate001
{
    delegate int MyDelegate(int p_iNumA, int p_iNumB);
    class Calculatoer
    {
        public int LF_Addtion(int p_iNumA, int p_iNumB)
        {

            return p_iNumA +p_iNumB; 
        }
        public int LF_Subtraction(int p_iNumA, int p_iNumB)
        {

            return p_iNumA - p_iNumB;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculatoer calculator = new Calculatoer();
            MyDelegate delCalCulator;
            delCalCulator = new MyDelegate(calculator.LF_Addtion);
            Console.WriteLine($"{delCalCulator(3, 4)}");

            delCalCulator = new MyDelegate(calculator.LF_Subtraction);
            Console.WriteLine($"{delCalCulator(4, 15)}");

            Console.ReadLine();

        }
    }
}
