using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_card_game
{
    class Players
    {
        public List<Player> players;


        public Players()
        {
            players = new List<Player>();
         

        }
        public void AddPlayers(int n)
        {
            for (int i = 0; i < n; i++)
            {

                Player newPlayer = new Player();
                newPlayer.Deal();
                players.Add(newPlayer);
                
                

            }
            

        }
     
        public void decideWinner()
        {
           
            SortPlayerList();
            Console.WriteLine(players[players.Count-1].ID);

        }
   
        private bool GreaterThan(Player a, Player b)
        {
            //create player's computer's evaluation objects (passing SORTED hand to constructor)
            HandEvaluator playera = new HandEvaluator(a.sortedplayerHand);
            HandEvaluator playerb = new HandEvaluator(b.sortedplayerHand);

            //get the player;s and computer's hand
            Hand playerAHand =playera.evaluatedHand();
            Hand playerBHand = playerb.evaluatedHand();



            if (playerAHand>playerBHand)
            {
                return true;
            }
            else if (playerAHand < playerBHand)
            {
                return false;
            }
            else //if the hands are the same, evaluate the values
            {
                //first evaluate who has higher value of poker hand
                if (playera.handValue.Total > playerb.handValue.Total)
                    return true;
                else if (playera.handValue.Total < playerb.handValue.Total)
                    return false;
                //if both hanve the same poker hand (for example, both have a pair of queens), 
                //than the player with the next higher card wins
                else if (playera.handValue.HighCard > playerb.handValue.HighCard)
                    return true;
                else if (playera.handValue.HighCard <playerb.handValue.HighCard)
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
