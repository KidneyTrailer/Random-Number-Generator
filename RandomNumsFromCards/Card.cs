using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumsFromCards
{
    class Card
    {
        public Card(CardValue cardValue, Suit suit)
        {
            Value = cardValue;
            Suit = suit;
        }

        public CardValue Value { get; private set; }
        public Suit Suit { get; private set; }

        public void Print()
        {
            Console.WriteLine("A {0} of {1}.", Value, Suit);
        }
    }
}
