using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab3_card_game
{
    class Deck:Card
    {
        const int NUM_OF_CARDS = 52;
        public List<Card> deck;
        public Deck()
        {
            deck = new List<Card>();

        }
        public List<Card> getDeck { get { return deck; } }

        public  void setUpDeck()
        {
            int i = 0;
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck.Add(new Card { MySuit = s, MyValue = v }) ;
                    i++;
                }
            }
            Debug.WriteLine(i);

            shuffleDeck();
           
        }

      
        public void shuffleDeck()
        {
            Random rand = new Random();
            Card temp;
            int t;

            for (int i = 0; i < deck.Count; i++)
            {
                t = rand.Next(0, 52);
                temp = deck[i];
                deck[i] = deck[t];
                deck[t] = deck[i];


            }

           
            

        }
        public void DrawCards(Player a)
        {
            for (int i = 0; i < 5; i++)
            {
                a.playerHand[i] = deck[i];
                deck.Remove(deck[i]);
            }

        }
    }
}
