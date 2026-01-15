using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomashnaRabota
{
    internal class Player
    {
        private static Random random = new Random();
        private string name;
        private int target;

        public Player(string playerName, int targetPoints)
        {
            name = playerName;
            target = targetPoints;
        }

        public void Run()
        {
            int currentPoints = 0;

            while (currentPoints <= target)
            {
                int add = random.Next(1, 10);
                currentPoints += add;
                Console.WriteLine($"{name} specheli {add} -> Obshto: {currentPoints}");
                Thread.Sleep(1000);
            }

            Console.WriteLine($"{name} PRIKLYUCHI!");
        }
    }
}
