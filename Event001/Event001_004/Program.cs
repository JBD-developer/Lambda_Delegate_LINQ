using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event001_004
{
    delegate void EventHandler(string messsage); 

    class MyNotifier
    {
        public event EventHandler SomeThingHappend;
        public void LF_DoSomeThing(int number)
        {
            int temp = number % 10;

            if (temp !=0 && temp% 3 == 0)
            {
                SomeThingHappend(string.Format("{0} : 짝", number));
            }
        }
    }
    class Program
    {
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomeThingHappend += new EventHandler(MyHandler);

            for (int i = 0; i < 30; i++)
            {
                notifier.LF_DoSomeThing(i);
            }
            Console.ReadLine();
        }
    }
}
