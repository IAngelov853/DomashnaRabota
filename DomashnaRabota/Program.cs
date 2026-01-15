using DomashnaRabota;
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prilojenie za Nishki");
        Console.WriteLine("1 - Dva broqcha nazad");
        Console.WriteLine("2 - Dve sastzavavashti se nishki");
        Console.Write("Izberi: ");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            RunCounters();
        }
        else if (choice == 2)
        {
            RunPlayers();
        }
        else
        {
            Console.WriteLine("Nevaliden izbor!");
        }
    }

    static void RunCounters()
    {
        Console.Write("Vuvedi nachalno chislo za obratno broene: ");
        int start = int.Parse(Console.ReadLine());

        CounterThread counter = new CounterThread(start);

        Thread t1 = new Thread(counter.CountBackwards);
        Thread t2 = new Thread(counter.CountBackwards);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Dvata broqcha priklyuchiha!");
    }

    static void RunPlayers()
    {
        Console.Write("Vuvedi krainite tochki: ");
        int target = int.Parse(Console.ReadLine());

        Player p1 = new Player("Player 1", target);
        Player p2 = new Player("Player 2", target);

        Thread t1 = new Thread(p1.Run);
        Thread t2 = new Thread(p2.Run);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Sustezanieto svurshi!");
    }
}
