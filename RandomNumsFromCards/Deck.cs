using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumsFromCards
{
    class Deck
    {

        Card[] cards;
        int deckLength, numDecks;

        public Deck(int numDecks = 1)
        {
            this.numDecks = numDecks;
            this.deckLength = 52 * numDecks;
            cards = new Card[deckLength];
            for (int i = 0; i < cards.Length; ++i)
                cards[i] = new Card(i);
        }

        public int GetCardValue(int i)
        {
            return cards[i].GetValue();
        }

        public int GetLength()
        {
            return deckLength;
        }

        public int GetNumDecks()
        {
            return numDecks;
        }

        public void Print()
        {
            Console.WriteLine("{0} {1} card deck[s].", numDecks, deckLength / numDecks);
        }

        public void Show() 
        {
            foreach (Card c in cards)
                c.Print();
        }

        public void Swap(int a, int b)
        {
            Card temp = cards[a];
            cards[a] = cards[b];
            cards[b] = temp;
        }
    }
}
