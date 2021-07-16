using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event001_003
{
    public class ButtonClass
    {
        public delegate void EventHandler();
        public event EventHandler Click; 

        public void LF_OnClick()
        {
            if (Click != null)
            {
                Click();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ButtonClass btn = new ButtonClass();

            btn.Click += new ButtonClass.EventHandler(LF_Print);
            btn.Click += new ButtonClass.EventHandler(LF_Print);

            btn.LF_OnClick();
            Console.ReadLine();
        }
        static void LF_Print()
        {
            Console.WriteLine("Event Print");
        }
    }
}
