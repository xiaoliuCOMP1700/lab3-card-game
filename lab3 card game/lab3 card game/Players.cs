using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_card_game
{
    class Players
    {
        List<Player> players;


        public Players()
        {
            players = new List<Player>();
         

        }
        public void AddPlayers(int n)
        {
            for (int i = 0; i < n-1; i++)
            {

                Player newPlayer = new Player();
                newPlayer.Deal();
                players.Add(newPlayer);
                

            }
            

        }
        public void RemovePlayer(int n)
        {
         
            players.RemoveAt(n - 1);
        }
        public void decideWinner()
        {
            foreach (var player in players)
            {
                player.Deal();
            }
            SortPlayerList();
            Console.WriteLine(players[players.Count-1]);

        }
        public void printResults()
        {
            foreach (var player in  players)
            { 
                player.print();
                Console.WriteLine(player.HandCount);
            }
         


        }
        private bool GreaterThan(Player a, Player b)
        {
            if (a.playerHandevaluator.evaluatedHand()>b.playerHandevaluator.evaluatedHand())
            {
                return true;
            }
            else if (a.playerHandevaluator.evaluatedHand() < b.playerHandevaluator.evaluatedHand())
            {
                return false;
            }
            else //if the hands are the same, evaluate the values
            {
                //first evaluate who has higher value of poker hand
                if (a.playerHandevaluator.handValue.Total > b.playerHandevaluator.handValue.Total)
                    return true;
                else if (a.playerHandevaluator.handValue.Total < b.playerHandevaluator.handValue.Total)
                    return false;
                //if both hanve the same poker hand (for example, both have a pair of queens), 
                //than the player with the next higher card wins
                else if (a.playerHandevaluator.handValue.HighCard > b.playerHandevaluator.handValue.HighCard)
                    return true;
                else if (a.playerHandevaluator.handValue.HighCard < b.playerHandevaluator.handValue.HighCard)
                    return false;
                else
                    Console.WriteLine("DRAW, no one wins!");
            }
            return false;
        }
        private void  SortPlayerList()
        {
            Player temp=new Player();
            for (int i = 0; i < players.Count-1; i++)
            {
                for (int j = 0; j <players.Count-1-i ; j++)
                {
                    if (GreaterThan(players[j],players[j+1]))
                    {
                        temp = players[j];
                        players[j] = players[j + 1];
                        players[j + 1] = temp;
                    }
                }
            }


        }

    }
}
