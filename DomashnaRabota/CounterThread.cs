using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomashnaRabota
{
    internal class CounterThread
    {
        private static Random random = new Random();
        private int start;

        public CounterThread(int startNumber)
        {
            start = startNumber;
        }

        public void CountBackwards()
        {
            int waitTime = random.Next(1, 10) * 1000;
            Console.WriteLine($"[Nishka] Chakane: {waitTime} ms");

            for (int i = start; i >= 0; i--)
            {
                Console.WriteLine($"[Nishka] {i}");
                Thread.Sleep(waitTime);
            }

            Console.WriteLine("[Nishka] Priklyuchi!");
        }
    }
}
