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
            Player a = new Player();
            Player b = new Player();
            Player c = new Player();
            a.ID = 1;
            b.ID = 2;
            c.ID = 3;

            Deck myDeck = new Deck();
            myDeck.setUpDeck();
            myDeck.DrawCards(a);
            myDeck.DrawCards(b);
            myDeck.DrawCards(c);

            a.Deal();
            b.Deal();
            c.Deal();

            
            a.print();
            b.print();
            c.print();

          
            Players myPlayers = new Players();
            myPlayers.players = new List<Player> { a, b, c };
            myPlayers.decideWinner();
            Console.ReadLine();
        }
    }
}
