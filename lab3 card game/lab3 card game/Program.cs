using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_card_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Players myPlayers = new Players();
            myPlayers.AddPlayers(2);
            myPlayers.decideWinner();


            Console.ReadLine();

        }
    }
}
