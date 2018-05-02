using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumsFromCards
{
    class Card
    {
        int value, suit;

        public Card(int value)
        {
            this.value = (value % 13) + 1;
            int suitValue = (value > 52) ? value - 52 * (value / 52) : value;
            this.suit = (suitValue < 52 / 4) ? 0 : (suitValue < 52 / 2) ? 1 : (suitValue < 52 * 3 / 4) ? 2 : 3;
        }

        string GetCardType() 
        {
            string card = "";
            if (value == 1) card = "Ace";
            else if (value == 11) card = "Jack";
            else if (value == 12) card = "Queen";
            else if (value == 13) card = "King";
            else card = Convert.ToString(value);
            return card;
        }

        string GetSuit()
        {
            string result = "Spades";
            if (suit == 1) result = "Hearts";
            else if (suit == 2) result = "Clubs";
            else if (suit == 3) result = "Diamonds";
            return result;
        }

        public int GetValue()
        {
            return value;
        }

        public void Print()
        {
            Console.WriteLine("A {0} of {1}.", GetCardType(), GetSuit());
        }
    }
}
