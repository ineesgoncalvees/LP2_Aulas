using System;

namespace Aula1_fortnite
{
    class Program
    {
        static void Main(string[] args)
        {
            FHPlayer player1 = new FHPlayer();
            FHPlayer player2 = new FHPlayer("machineGun", 100, 100);

            Console.WriteLine("Shield before: " + player2.GetShield());
            player1.Attack(player2);
            Console.WriteLine("Shield after: " + player2.GetShield());



            Console.WriteLine("Shield before: " + player1.GetShield());
            player1.SetShield(50);
            Console.WriteLine("Shield after: " + player1.GetShield());

            FHPlayer.maxHitPoints = 50;
        }
    }
}
