using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_fortnite
{
    class Program
    {
        static void Main(string[] args)
        {
            FHPlayer player1 = new FHPlayer();
            FHPlayer player2 = new FHPlayer("machineGun", 100, 100);

            Console.WriteLine("Shield before: " + player2.shield);
            Console.WriteLine("Hit points before: " + player2.hitPoints);

            player1.Attack(player2);

            Console.WriteLine("Shield after: " + player2.shield);
            Console.WriteLine("Hit points after: " + player2.hitPoints);
        }
    }
}
