using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_card_game
{
    class Card
    {
        public enum SUIT
        {
            HEARTS,
            SPADES,
            DIAMONDS,
            CLUBS
        }
        public enum VALUE
        {
            Two = 2, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
        }

        public SUIT MySuit { get; set; }
        public VALUE MyValue { get; set; }
        public override string ToString()
        {
            return MySuit.ToString().ToUpper() +"of"+ MyValue.ToString();

        }

    }
}
