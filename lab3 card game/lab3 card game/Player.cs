using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_card_game
{
    class Player:Deck
    {
        public Card[] playerHand;
        public Card[] sortedplayerHand;
        public Hand HandCount;
        public HandEvaluator playerHandevaluator;
        
        public Player()
            {
                playerHand=new Card[5];
            sortedplayerHand = new Card[5];
            playerHandevaluator = new HandEvaluator(sortedplayerHand);
          
            
            }

        public void Deal()
        {
            setUpDeck();
            getHand();
            sortCards();

        }
      
        private void getHand()
        {
            //5 cards for the player
            for (int i = 0; i < 5; i++)
                playerHand[i] = getDeck[i];

         
        }
        private void sortCards()
        {
            var queryPlayer = from hand in playerHand
                              orderby hand.MyValue
                              select hand;

            var index = 0;
            foreach (var element in queryPlayer.ToList())
            {
                sortedplayerHand[index] = element;
                index++;
            }

         
        }

        public void print()
        {
            for (int i = 0; i < sortedplayerHand.Length; i++)
            {
                Console.WriteLine(sortedplayerHand[i]);
            }

        }

    }
    
}
