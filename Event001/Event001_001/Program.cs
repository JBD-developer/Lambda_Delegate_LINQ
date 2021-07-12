using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event001_001
{
    
    public class Metronome
    {
        public event TickHandler Tick;
        public delegate void TickHandler(Metronome m, EventArgs e);
        public EventArgs e = null;
        
        public void LF_Start()
        {
            while (true)
            {
                Thread.Sleep(TimeSpan.FromSeconds(3));
                if (Tick != null)
                {
                    Tick(this, e);
                }
            }
        }
    }
    
    public class Listener
    {
        public void LF_Subcribe(Metronome m)
        {
            m.Tick += new Metronome.TickHandler(LF_HeardIt);
        }

        private void LF_HeardIt(Metronome m, EventArgs e)
        {
            Console.WriteLine("Heard It");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Metronome metronome = new Metronome();
            Listener listener = new Listener();
            listener.LF_Subcribe(metronome);
            metronome.LF_Start();
            Console.ReadLine();
        }
    }
}
