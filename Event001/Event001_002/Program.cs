using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event001_002
{
    public class TimeOfTock : EventArgs
    {
        private DateTime TimeNow;

        public DateTime Time
        {
            get
            {
                return this.TimeNow;
            }

            set
            {
                TimeNow = value;
            }
        }
    
    }

    public class Metronome
    {
        public event TickHandler Tick;
        public delegate void TickHandler(Metronome m, TimeOfTock e);

        public void LF_Start()
        {

            while (true)
            {
                Thread.Sleep(TimeSpan.FromSeconds(10));
                
                if (Tick != null)
                {
                    TimeOfTock tot = new TimeOfTock();
                    tot.Time = DateTime.Now;
                    Tick(this, tot);
                }
            }
            
        }
    }

    public class Listener
    {
        public void LF_Subscribe(Metronome m)
        {
            m.Tick += new Metronome.TickHandler(LF_HeardIt);
        }

        private void LF_HeardIt(Metronome m, TimeOfTock e)
        {
            Console.WriteLine($"HEARD IT AT {e.Time}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var metronome = new Metronome();
            var listener = new Listener();
            listener.LF_Subscribe(metronome);
            metronome.LF_Start();
        }
    }
}
