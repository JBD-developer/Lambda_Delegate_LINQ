using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event001
{
    public class Criminal
    {
        public delegate void BehaviorHandler(Criminal child, EventArgs e);
        public EventArgs e = null;
        public event BehaviorHandler _behavior;
    
        public void LF_Observe()
        {
            while (true)
            {
                Console.WriteLine("#[criminal] Report criminal's behavior");
                var action = Console.ReadLine();
                if (action == "steal")
                {
                    if (_behavior != null)
                    {
                        Console.WriteLine($"It is dangerous that the criminal has {action}");
                        //Event 발생
                        _behavior(this, e);
                    }
                }
                else
                {
                    Console.WriteLine($"It's Okay that the criminal has {action} ");
                }
            }
        }
    }

    public class Police
    {
        public void LF_Subscribe(Criminal c)
        {
            c._behavior += new Criminal.BehaviorHandler(LF_Arrest);
        }
        private void LF_Arrest(Criminal c, EventArgs e)
        {
            Console.WriteLine("#[Police] Arrested the criminal");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var criminal = new Criminal();
            var police = new Police();
            police.LF_Subscribe(criminal);
            criminal.LF_Observe();
        }
    }
}
