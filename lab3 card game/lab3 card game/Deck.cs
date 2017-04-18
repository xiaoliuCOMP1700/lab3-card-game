using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_card_game
{
    class Deck:Card
    {
        const int NUM_OF_CARDS = 52;
        Card[] deck;
        public Deck()
        {
            deck = new Card[NUM_OF_CARDS];

        }
        
        public void setUpDeck()
        {
            int i = 0;
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { MySuit=s, MyValue=v };
                    i++;
                }
            }

            shuffleDeck();
        }

        public Card[] getDeck { get { return deck; } } //get current deck
        public void shuffleDeck()
        {
            Random rand = new Random();
            Card temp;

            //run the shuffle 1000 times
            for (int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            {
                for (int i = 0; i < NUM_OF_CARDS; i++)
                {
                    //swap the cards
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }

        }
    }
}
